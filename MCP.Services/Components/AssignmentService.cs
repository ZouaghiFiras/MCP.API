// Bring in the necessary namespaces for the classes and interfaces used in this code
using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using MCP.Data.Interfaces;
using MCP.Data.Models;
using MCP.Services.Contracts;
using MCP.Services.DTO;

namespace MCP.Services.Components
{
    /// <summary>
    ///     Service responsible for managing assignments.
    /// </summary>
    public class AssignmentService : IAssignmentService
    {
        private readonly IAssignmentRepository _assignmentRepository;
        private readonly IMapper _mapper;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AssignmentService"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="assignmentRepository">The assignment repository.</param>
        public AssignmentService(IMapper mapper, IAssignmentRepository assignmentRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _assignmentRepository = assignmentRepository ?? throw new ArgumentNullException(nameof(assignmentRepository));
        }

        /// <summary>
        ///     Gets all assignments.
        /// </summary>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>All assignments.</returns>
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        public IEnumerable<Assignment> GetAll(string cultureCode)
        {
            var result = _assignmentRepository.GetAllAssignments(cultureCode);
            return _mapper.Map<IEnumerable<Assignment>>(result);
        }
        /// <summary>
        ///     Get a list of assignments based on the provided search criteriavalues.
        /// </summary>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>The results of the search on assignments.</returns>
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        public IEnumerable<Assignment> GetSearchResults(SearchCriteria searchCriteria, string cultureCode)
        {
            var result = _assignmentRepository.Search(searchCriteria, cultureCode);
            var assignments = result.ToList();

            return _mapper.Map<IEnumerable<Assignment>>(assignments);
        }
        /// <summary>
        ///     Gets a page of assignments based on search criteria.
        /// </summary>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <param name="skip">The number of assignments to skip.</param>
        /// <param name="take">The number of assignments to take.</param>
        /// <returns>A page of assignments.</returns>
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        public PagingDto GetPaginatedResults(SearchCriteria searchCriteria, string cultureCode, int skip, int take)
        {
            var result = _assignmentRepository.Search(searchCriteria, cultureCode);
            var enumerable = result.ToList();
            var assignments = enumerable.Skip(skip).Take(take).ToList();
            var pagingDto = new PagingDto
            {
                Assignments = _mapper.Map<List<Assignment>>(assignments),
                Total = enumerable.Count()
            };

            return pagingDto;
        }

        /// <summary>
        ///     Gets the details of an assignment by assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>The details of an assignment.</returns>
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        public AssignmentDetails GetAssignmentDetailsByAssignmentNumber(string assignmentNumber, string cultureCode)
        {
            var result = _assignmentRepository.GetAssignmentDetails(assignmentNumber, cultureCode);
            return _mapper.Map<AssignmentDetails>(result);
        }
    }
}
