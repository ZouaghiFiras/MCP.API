namespace CED.Data.Entities
{
    public class ReportingFormActivityExecution
    {
        public Guid RfxId { get; set; }

        public byte[] RfxTimeStamp { get; set; } = null!;

        public Guid? RfxReportingFormId { get; set; }

        public Guid? RfxActivityExecutionId { get; set; }

        public DateTime RfxCreatedDate { get; set; }

        public string? RfxCreatedBy { get; set; }

        public DateTime RfxLastModifiedDate { get; set; }

        public string? RfxLastModifiedBy { get; set; }

        public virtual ActivityExecution? RfxActivityExecution { get; set; }

        public virtual ReportingForm? RfxReportingForm { get; set; }
    }
}