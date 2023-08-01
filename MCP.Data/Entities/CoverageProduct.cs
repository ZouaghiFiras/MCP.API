namespace CED.Data.Entities
{
    public class CoverageProduct
    {
        public Guid CprdId { get; set; }

        public byte[] CprdTimeStamp { get; set; } = null!;

        public string CprdProductCode { get; set; } = null!;

        public string CprdProductName { get; set; } = null!;

        public string? CprdSpecificInformation { get; set; }

        public bool CprdInactive { get; set; }

        public DateTime CprdStartDate { get; set; }

        public DateTime? CprdEndDate { get; set; }

        public string? CprdRegulationCode { get; set; }

        public string? CprdProductNameCommercial { get; set; }

        public bool CprdDefaultWa { get; set; }

        public string? CprdProductCodeOriginal { get; set; }

        public Guid? CprdLocalizableEntryId { get; set; }

        public Guid CprdOrganizationUnitOwnerId { get; set; }

        public Guid? CprdCoverageProductTypeId { get; set; }

        public DateTime CprdCreatedDate { get; set; }

        public string? CprdCreatedBy { get; set; }

        public DateTime CprdLastModifiedDate { get; set; }

        public string? CprdLastModifiedBy { get; set; }

        public Guid? CprdInsuranceCoverageId { get; set; }

        public virtual CoverageProductType? CprdCoverageProductType { get; set; }

        public virtual InsuranceCoverage? CprdInsuranceCoverage { get; set; }

        public virtual LocalizableEntry? CprdLocalizableEntry { get; set; }

        public virtual OrganizationUnit CprdOrganizationUnitOwner { get; set; } = null!;

        public virtual ICollection<InvolvedCoverage> InvolvedCoverages { get; } = new List<InvolvedCoverage>();

        public virtual ICollection<OrganizationCoverageProduct> OrganizationCoverageProducts { get; } =
            new List<OrganizationCoverageProduct>();
    }
}