namespace CED.Data.Entities
{
    public class ReportingForm
    {
        public Guid RfId { get; set; }

        public byte[] RfTimeStamp { get; set; } = null!;

        public string RfCode { get; set; } = null!;

        public string? RfShortName { get; set; }

        public string RfLongName { get; set; } = null!;

        public bool RfInactive { get; set; }

        public Guid? RfLocalizableEntryId { get; set; }

        public DateTime RfCreatedDate { get; set; }

        public string? RfCreatedBy { get; set; }

        public DateTime RfLastModifiedDate { get; set; }

        public string? RfLastModifiedBy { get; set; }

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual ICollection<FeeSettlementReportingFormOption> FeeSettlementReportingFormOptions { get; } =
            new List<FeeSettlementReportingFormOption>();

        public virtual ICollection<ProductExclusionOption> ProductExclusionOptions { get; } =
            new List<ProductExclusionOption>();

        public virtual ICollection<ProductExclusion> ProductExclusions { get; } = new List<ProductExclusion>();

        public virtual ICollection<ReportingFormActivityExecution> ReportingFormActivityExecutions { get; } =
            new List<ReportingFormActivityExecution>();

        public virtual LocalizableEntry? RfLocalizableEntry { get; set; }
    }
}