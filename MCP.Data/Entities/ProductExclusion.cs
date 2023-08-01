namespace CED.Data.Entities
{
    public class ProductExclusion
    {
        public Guid PexId { get; set; }

        public byte[] PexTimeStamp { get; set; } = null!;

        public Guid? PexProductId { get; set; }

        public Guid? PexWorkActivityId { get; set; }

        public Guid? PexInsuranceObjectId { get; set; }

        public Guid? PexDamageReasonId { get; set; }

        public Guid? PexInsuranceCoverageId { get; set; }

        public bool PexInactive { get; set; }

        public DateTime PexCreatedDate { get; set; }

        public string? PexCreatedBy { get; set; }

        public DateTime PexLastModifiedDate { get; set; }

        public string? PexLastModifiedBy { get; set; }

        public Guid? PexActivityExecutionId { get; set; }

        public Guid? PexReportingFormId { get; set; }

        public bool? PexIsPrivate { get; set; }

        public bool? PexIsBusiness { get; set; }

        public Guid? PexActivityOptionId { get; set; }

        public Guid? PexReportingFormActivityOptionId { get; set; }

        public virtual ActivityExecution? PexActivityExecution { get; set; }

        public virtual ActivityOption? PexActivityOption { get; set; }

        public virtual DamageReason? PexDamageReason { get; set; }

        public virtual InsuranceCoverage? PexInsuranceCoverage { get; set; }

        public virtual InsuranceObject? PexInsuranceObject { get; set; }

        public virtual Product? PexProduct { get; set; }

        public virtual ReportingForm? PexReportingForm { get; set; }

        public virtual ActivityOption? PexReportingFormActivityOption { get; set; }

        public virtual WorkActivity? PexWorkActivity { get; set; }
    }
}