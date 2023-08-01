// Bring in the necessary namespaces for the classes and interfaces used in this code

using System.Diagnostics.CodeAnalysis;
using MCP.Data.Helpers;
using MCP.Data.Interfaces;
using MCP.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace MCP.Data.Repositories
{
    /// <summary>
    /// Repository for managing assignments.
    /// </summary>
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly ICacheProvider _cacheProvider;
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentRepository"/> class.
        /// </summary>
        /// <param name="dataContext">The data context.</param>
        /// <param name="cacheProvider">The cache provider.</param>
        public AssignmentRepository(DataContext dataContext, ICacheProvider cacheProvider)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _cacheProvider = cacheProvider ?? throw new ArgumentNullException(nameof(cacheProvider));
            _dataContext.Database.SetCommandTimeout(50000);
        }

        /// <summary>
        ///     Gets all assignments with related data.
        /// </summary>
        /// <param name="cultureCode">The culture code.</param>
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        public IEnumerable<Assignment> GetAllAssignments(string cultureCode)
        {
            // Load dossier assignments with related data.
            var dossierAssignments = _dataContext.DossierAssignments
                .AsNoTracking()
                .Include(x => x.DoaDossier.AdviceDossier)
                .Include(x => x.DoaDossier.DosDepartment.Dep)
                .Include(x => x.DossierParties)
                .ThenInclude(dp => dp.DopInvolvedParty)
                .Include(x => x.DossierAssignmentStatusHistories)
                .ThenInclude(ash => ash.AshDossierAssignmentStatus)
                .ToList();

            // Build the result list by mapping dossier assignments to assignments.
            var result = dossierAssignments.Select(x => new Assignment
            {
                AssignmentNumber = x.DoaAssignmentNumber,
                DamageDate = x.DoaDossier.AdviceDossier.AvdDamageDate,
                OrderNumber = x.DoaClientOrderNumber,
                CaseNumber = x.DoaClientCaseNumber,
                InvolvedParty = x.DoaDossier.DossierParties.FirstOrDefault()?.DopInvolvedParty?.IpaFullName,
                Status = GetLocalizedValue(x.DossierAssignmentStatusHistories
                        .OrderByDescending(h => h.AshStartDate)
                        .FirstOrDefault().AshDossierAssignmentStatus.AstLocalizableEntryId,
                    cultureCode,
                    x.DossierAssignmentStatusHistories
                        .OrderByDescending(h => h.AshStartDate)
                        .FirstOrDefault().AshDossierAssignmentStatus.AstShortName,
                    _cacheProvider),
                Department = x.DoaDossier.DosDepartment.Dep.OuLongName
            }).ToList();

            return result;
        }

        /// <summary>
        ///     Searches for assignments based on the specified search criteria and culture code.
        /// </summary>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>A list of assignments matching the search criteria.</returns>
        public IEnumerable<Assignment> Search(SearchCriteria searchCriteria, string cultureCode)
        {
            // Parameter validation
            if (searchCriteria is null)
            {
                throw new ArgumentNullException(nameof(searchCriteria), "Search criteria cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(cultureCode))
            {
                throw new ArgumentException("Culture code cannot be null or empty.", nameof(cultureCode));
            }
            
            if (searchCriteria.AssignmentNumber.IsNullOrEmpty() 
                &&searchCriteria.CaseNumber.IsNullOrEmpty()
                &&searchCriteria.PolicyNumber.IsNullOrEmpty() 
                &&searchCriteria.HouseNumber.IsNullOrEmpty()
                &&searchCriteria.OrderNumber.IsNullOrEmpty() 
                &&searchCriteria.PostalCode.IsNullOrEmpty()
                )
            {
                return new List<Assignment>();
            }
            
            var query = _dataContext.DossierAssignments
                .AsNoTracking()
                .Include(x => x.DoaDossier.AdviceDossier)
                .Include(x => x.DoaDossier.DosDepartment.Dep)
                .Include(x => x.DossierParties)
                .ThenInclude(dp => dp.DopInvolvedParty)
                .Include(x => x.DossierAssignmentStatusHistories)
                .ThenInclude(ash => ash.AshDossierAssignmentStatus)
                .Where(x =>
                    (string.IsNullOrWhiteSpace(searchCriteria.OrderNumber) ||
                     x.DoaClientOrderNumber.Contains(searchCriteria.OrderNumber)) &&
                    (string.IsNullOrWhiteSpace(searchCriteria.PolicyNumber) ||
                     x.DoaInvolvedCoverage.IcoInsurancePolicyNumber.Contains(searchCriteria.PolicyNumber)) &&
                    (string.IsNullOrWhiteSpace(searchCriteria.CaseNumber) ||
                     x.DoaClientCaseNumber.Contains(searchCriteria.CaseNumber)) &&
                    (string.IsNullOrWhiteSpace(searchCriteria.PostalCode) || x.DossierParties.Any(dp =>
                        dp.DopInvolvedParty.IpaPostalCode.Contains(searchCriteria.PostalCode))) &&
                    (string.IsNullOrWhiteSpace(searchCriteria.HouseNumber) || x.DossierParties.Any(dp =>
                        dp.DopInvolvedParty.IpaHouseNumber.Contains(searchCriteria.HouseNumber))) &&
                    (string.IsNullOrWhiteSpace(searchCriteria.AssignmentNumber) ||
                     x.DoaAssignmentNumber.Contains(searchCriteria.AssignmentNumber))
                )
                .OrderByDescending(x => x.DoaCurrentStatusHistoryStartDate);

            var result = query.Select(x => new Assignment
            {
                AssignmentNumber = x.DoaAssignmentNumber,
                DamageDate = x.DoaDossier.AdviceDossier.AvdDamageDate,
                OrderNumber = x.DoaClientOrderNumber,
                CaseNumber = x.DoaClientCaseNumber,
                InvolvedParty = x.DossierParties.FirstOrDefault(dp => dp.DopDossierAssignmentId == x.DoaId)
                    .DopInvolvedParty.IpaFullName,
                Status = GetLocalizedValue(x.DossierAssignmentStatusHistories
                        .OrderByDescending(h => h.AshStartDate)
                        .FirstOrDefault().AshDossierAssignmentStatus.AstLocalizableEntryId,
                    cultureCode,
                    x.DossierAssignmentStatusHistories
                        .OrderByDescending(h => h.AshStartDate)
                        .FirstOrDefault().AshDossierAssignmentStatus.AstShortName,
                    _cacheProvider),
                Department = x.DoaDossier.DosDepartment.Dep.OuLongName
            }).ToList();

            return result;
        }

        /// <summary>
        ///     Retrieves assignment details for the given assignment number and culture code.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>The assignment details.</returns>
        public AssignmentDetails GetAssignmentDetails(string assignmentNumber, string cultureCode)
        {
            // Parameter validation
            if (assignmentNumber is null)
            {
                throw new ArgumentNullException(nameof(assignmentNumber), "Assignment Number cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(cultureCode))
            {
                throw new ArgumentException("Culture code cannot be null or empty.", nameof(cultureCode));
            }

            // Select the relevant DossierAssignment based on the assignment number
            return _dataContext.DossierAssignments
                .Where(da => da.DoaAssignmentNumber == assignmentNumber)
                .Select(da => new AssignmentDetails
                {
                    // Define the AssignmentDetails object and populate its properties
                    Status = GetLocalizedValue(da.DossierAssignmentStatusHistories
                            .OrderByDescending(h => h.AshStartDate)
                            .FirstOrDefault().AshDossierAssignmentStatus.AstLocalizableEntryId,
                        cultureCode,
                        da.DossierAssignmentStatusHistories
                            .OrderByDescending(h => h.AshStartDate)
                            .FirstOrDefault().AshDossierAssignmentStatus.AstShortName,
                        _cacheProvider),
                    PolicyNumber = da.DoaInvolvedCoverage.IcoInsurancePolicyNumber,
                    InsuredAmount = da.DoaInvolvedObject.Property.PrpInsuredAmount,
                    OwnRisk = da.DoaInvolvedObject.Property.PrpDeductibleExcess,
                    PolicyConditions = da.DoaInvolvedObject.Property.PrpPolicyConditions,
                    DamageNumber = da.DoaDossier.AdviceDossier.AvdCaseNumber,
                    DamageDate = da.DoaDossier.AdviceDossier.AvdDamageDate,
                    EstimatedDamageAmount = da.DoaDossier.AdviceDossier.AvdDamageAmountEstimate,
                    Recovery = da.DoaDossier.AdviceDossier.AvdRecoveryPossible,
                    Department = da.DoaDossier.DosDepartment.Dep.OuShortName,
                    WorkActivity = GetLocalizedValue(da.DossierWorkActivities
                            .FirstOrDefault(pdc => pdc.DwaWorkActivity.WaIsMain)
                            .DwaWorkActivity.WaLocalizableEntryId, cultureCode,
                        da.DossierWorkActivities
                            .FirstOrDefault(pdc => pdc.DwaWorkActivity.WaIsMain)
                            .DwaWorkActivity.WaShortName, _cacheProvider),
                    ActivityExecution = GetLocalizedValue(da.DossierWorkActivities
                            .Where(pdc =>
                                pdc.DwaActivityOptionId != null &&
                                pdc.DwaActivityOption.AoActivityOptionType.AotShortName == "ActivityExecution")
                            .Select(pdc => pdc.DwaActivityOption.AoLocalizableEntryId)
                            .FirstOrDefault(),
                        cultureCode,
                        da.DossierWorkActivities
                            .Where(pdc =>
                                pdc.DwaActivityOptionId != null &&
                                pdc.DwaActivityOption.AoActivityOptionType.AotShortName == "ActivityExecution")
                            .Select(pdc => pdc.DwaActivityOption.AoShortName)
                            .FirstOrDefault(),
                        _cacheProvider),
                    ReportingForm = GetLocalizedValue(da.DossierWorkActivities
                            .Where(pdc =>
                                pdc.DwaActivityOptionId != null &&
                                pdc.DwaActivityOption.AoActivityOptionType.AotShortName == "ReportingForm")
                            .Select(pdc => pdc.DwaActivityOption.AoLocalizableEntryId)
                            .FirstOrDefault(),
                        cultureCode,
                        da.DossierWorkActivities
                            .Where(pdc =>
                                pdc.DwaActivityOptionId != null &&
                                pdc.DwaActivityOption.AoActivityOptionType.AotShortName == "ReportingForm")
                            .Select(pdc => pdc.DwaActivityOption.AoShortName)
                            .FirstOrDefault(),
                        _cacheProvider),
                    Object = GetLocalizedValue(da.DoaInvolvedObject.IobInsuranceObject.IoLocalizableEntryId,
                        cultureCode,
                        da.DoaInvolvedObject.IobInsuranceObject.IoShortName,
                        _cacheProvider),
                    Cause = GetLocalizedValue(da.DoaDossier.DosReason.DrLocalizableEntryId,
                        cultureCode,
                        da.DoaDossier.DosReason.DrShortName,
                        _cacheProvider),
                    Coverage = GetLocalizedValue(da.DoaInvolvedCoverage.IcoInsuranceCoverage.IcLocalizableEntryId,
                        cultureCode,
                        da.DoaInvolvedCoverage.IcoInsuranceCoverage.IcShortName,
                        _cacheProvider),
                    Product = GetLocalizedValue(da.DoaProduct.PrdLocalizableEntryId,
                        cultureCode,
                        da.DoaProduct.PrdShortName,
                        _cacheProvider),
                    Client = da.DoaDossier.DosClient.Cl.OuShortName,
                    ContactPerson = da.DoaDossier.DossierContactPeople
                        .OrderBy(dcp => dcp.DcpCreatedDate)
                        .Select(dcp => dcp.DcpContactPerson.CpFullName)
                        .FirstOrDefault(),
                    ContactPersonEmail = da.DoaDossier.DossierContactPeople
                        .OrderBy(dcp => dcp.DcpCreatedDate)
                        .Select(dcp => dcp.DcpContactPerson.CpEmail)
                        .FirstOrDefault(),
                    IntakeMethod = da.DoaDossier.DossierContactPeople
                        .OrderBy(dcp => dcp.DcpCreatedBy)
                        .Select(dcp => dcp.DcpContactPerson.CpIntakeMethod)
                        .FirstOrDefault(),
                    DeedOfAssignment = da.DoaInvolvedObject.Property.PrpDeedOfAssignment,
                    Expert = da.DossierAssignmentVisitInformations
                        .Where(dav => !dav.DavVisitInformation.VisitInformationStatusHistories
                            .Any(vish => vish.VishVisitInformationStatus.VisCode == "7"))
                        .OrderByDescending(dav => dav.DavCreatedDate)
                        .Select(dav => dav.DavVisitInformation.VifEmployee.EmpFullName)
                        .FirstOrDefault(),
                    VisitDate = da.DossierAssignmentVisitInformations
                        .Where(x => !x.DavVisitInformation
                            .VisitInformationStatusHistories.Any(y => y.VishVisitInformationStatus.VisCode == "7"))
                        .OrderByDescending(x => x.DavCreatedDate)
                        .Select(x => x.DavVisitInformation.VifVisitDate)
                        .FirstOrDefault(),
                    Handler = da.DossierAssignmentHandlerHistories
                        .OrderBy(x => x.AhhCreatedDate)
                        .LastOrDefault(x => x.AhhDossierAssignmentEmployeeType.AetName == "Handler")
                        .AhhEmployee.EmpFullName,

                    Parties = da.DossierAssignmentParties.Select(dp => new PartyData
                    {
                        PartyType = GetLocalizedValue(dp.DapDossierParty.DopInvolvedPartyRole.RcLocalizableEntryId,
                            cultureCode,
                            dp.DapDossierParty.DopInvolvedPartyRole.RcShortName,
                            _cacheProvider),
                        PartyName = dp.DapDossierParty.DopInvolvedParty.IpaFullName,
                        PartyAddress = dp.DapDossierParty.DopInvolvedParty.IpaFullAddress
                    })
                }).FirstOrDefault();
        }

        /// <summary>
        ///     Retrieves the localized value for a given localizable entry ID and culture code from a collection of localized
        ///     entries. If no localized value is found, the default value is returned.
        /// </summary>
        /// <param name="localizableEntryId">The ID of the localizable entry to search for.</param>
        /// <param name="cultureCode">The culture code to search for.</param>
        /// <param name="defaultValue">The default value to return if no localized value is found.</param>
        /// <returns>The localized value for the given localizable entry ID and culture code, or the default value if not found.</returns>
        private static string GetLocalizedValue(Guid? localizableEntryId, string cultureCode, string defaultValue,
            ICacheProvider cacheProvider)
        {
            if (cacheProvider == null)
            {
                throw new InvalidOperationException("Cache provider has not been initialized.");
            }

            // Search for a localized entry matching the given localizable entry ID and culture code
            var localizedEntry = cacheProvider.lstLocalizedEntries
                .FirstOrDefault(x => x.LlcLocalizableEntryId == localizableEntryId && x.LlcCultureCode == cultureCode);

            // Return the localized value if it exists, or the default value otherwise
            return localizedEntry?.LlcLongTranslation ?? defaultValue;
        }
    }
}