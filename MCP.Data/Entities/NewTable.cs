namespace CED.Data.Entities
{
    public class NewTable
    {
        public Guid? ActivityId { get; set; }

        public string? ActivityCode { get; set; }

        public string? ActivityName { get; set; }

        public bool? WaInactive { get; set; }

        public bool? WaIsClientTask { get; set; }

        public Guid? CoverageId { get; set; }

        public string? CoverageCode { get; set; }

        public string? CoverageName { get; set; }

        public bool? IsMainCoverage { get; set; }

        public Guid? ObjectId { get; set; }

        public string? ObjectCode { get; set; }

        public string? ObjectName { get; set; }

        public bool? IsMainObject { get; set; }

        public Guid? DamageReasonId { get; set; }

        public string? DamageReasonCode { get; set; }

        public string? DamageReasonName { get; set; }

        public bool? IsMainDamageReason { get; set; }

        public Guid? ActivityOptionId { get; set; }

        public string? ActivityOptionName { get; set; }

        public string? ActivityOptionCode { get; set; }

        public Guid? ReportingFormId { get; set; }

        public string? ReportingFormName { get; set; }

        public string? ReportingFormCode { get; set; }

        public Guid ProductId { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public string ProductTypeCode { get; set; } = null!;

        public string? ProductTypeName { get; set; }

        public bool PoductInactive { get; set; }

        public Guid? ProductWorkActivityId { get; set; }

        public bool? IsMainProductWorkActivity { get; set; }

        public Guid? ProductInsuranceObjectId { get; set; }

        public Guid? ProductInsuranceCoverageId { get; set; }

        public Guid? ProductDamageReasonId { get; set; }
    }
}