namespace CED.Data.Entities
{
    public class InsuranceCoverage
    {
        public Guid IcId { get; set; }

        public byte[] IcTimeStamp { get; set; } = null!;

        public string IcCode { get; set; } = null!;

        public string? IcShortName { get; set; }

        public string IcLongName { get; set; } = null!;

        public Guid? IcInsuranceCoverageTypeId { get; set; }

        public bool IcInactive { get; set; }

        public Guid? IcLocalizableEntryId { get; set; }

        public DateTime IcCreatedDate { get; set; }

        public string? IcCreatedBy { get; set; }

        public DateTime IcLastModifiedDate { get; set; }

        public string? IcLastModifiedBy { get; set; }

        public bool IcIsMain { get; set; }

        public virtual ICollection<ClientInsuranceProduct> ClientInsuranceProducts { get; } =
            new List<ClientInsuranceProduct>();

        public virtual ICollection<ContractInsuranceCoverage> ContractInsuranceCoverages { get; } =
            new List<ContractInsuranceCoverage>();

        public virtual ICollection<CoverageProduct> CoverageProducts { get; } = new List<CoverageProduct>();

        public virtual ICollection<FeeSettlementLine> FeeSettlementLines { get; } = new List<FeeSettlementLine>();

        public virtual InsuranceCoverageType? IcInsuranceCoverageType { get; set; }

        public virtual LocalizableEntry? IcLocalizableEntry { get; set; }

        public virtual ICollection<InsuranceCoverageHierarchy> InsuranceCoverageHierarchies { get; } =
            new List<InsuranceCoverageHierarchy>();

        public virtual ICollection<InvolvedCoverage> InvolvedCoverages { get; } = new List<InvolvedCoverage>();

        public virtual ICollection<ProductExclusion> ProductExclusions { get; } = new List<ProductExclusion>();

        public virtual ICollection<ProductInsuranceCoverage> ProductInsuranceCoverages { get; } =
            new List<ProductInsuranceCoverage>();
    }
}