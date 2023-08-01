namespace CED.Data.Entities
{
    public class ActivityExecution
    {
        public Guid AeId { get; set; }

        public byte[] AeTimeStamp { get; set; } = null!;

        public string AeCode { get; set; } = null!;

        public string? AeShortName { get; set; }

        public string AeLongName { get; set; } = null!;

        public bool AeInactive { get; set; }

        public Guid? AeLocalizableEntryId { get; set; }

        public DateTime AeCreatedDate { get; set; }

        public string? AeCreatedBy { get; set; }

        public DateTime AeLastModifiedDate { get; set; }

        public string? AeLastModifiedBy { get; set; }

        public virtual LocalizableEntry? AeLocalizableEntry { get; set; }

        public virtual ICollection<ContractActivityExecution> ContractActivityExecutions { get; } =
            new List<ContractActivityExecution>();

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual ICollection<FeeSettlementLine> FeeSettlementLines { get; } = new List<FeeSettlementLine>();

        public virtual ICollection<ProductExclusionOption> ProductExclusionOptions { get; } =
            new List<ProductExclusionOption>();

        public virtual ICollection<ProductExclusion> ProductExclusions { get; } = new List<ProductExclusion>();

        public virtual ICollection<ReportingFormActivityExecution> ReportingFormActivityExecutions { get; } =
            new List<ReportingFormActivityExecution>();

        public virtual ICollection<WorkActivity> WorkActivities { get; } = new List<WorkActivity>();

        public virtual ICollection<WorkActivityExecution> WorkActivityExecutions { get; } =
            new List<WorkActivityExecution>();
    }
}