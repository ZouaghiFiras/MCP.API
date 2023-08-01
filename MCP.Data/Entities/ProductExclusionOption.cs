namespace CED.Data.Entities
{
    public class ProductExclusionOption
    {
        public Guid PeoId { get; set; }

        public byte[] PeoTimeStamp { get; set; } = null!;

        public Guid? PeoProductId { get; set; }

        public Guid? PeoActivityExecutionId { get; set; }

        public Guid? PeoReportingFormId { get; set; }

        public bool? PeoIsPrivate { get; set; }

        public bool? PeoIsBusiness { get; set; }

        public bool PeoInactive { get; set; }

        public DateTime PeoCreatedDate { get; set; }

        public string? PeoCreatedBy { get; set; }

        public DateTime PeoLastModifiedDate { get; set; }

        public string? PeoLastModifiedBy { get; set; }

        public virtual ActivityExecution? PeoActivityExecution { get; set; }

        public virtual ReportingForm? PeoReportingForm { get; set; }
    }
}