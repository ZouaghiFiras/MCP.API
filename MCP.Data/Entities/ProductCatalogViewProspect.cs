namespace CED.Data.Entities
{
    public class ProductCatalogViewProspect
    {
        public string ProductTypeCode { get; set; } = null!;

        public string? ProductTypeName { get; set; }

        public string ProductGroupCode { get; set; } = null!;

        public string ProductGroupName { get; set; } = null!;

        public Guid ProductGroupId { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public Guid ProductId { get; set; }

        public string? Department { get; set; }

        public string? ActivityCode { get; set; }

        public string? ActivityName { get; set; }

        public Guid? ActivityId { get; set; }

        public bool? IsMainActivity { get; set; }

        public bool? IsEconomicLoss { get; set; }

        public bool? IsCoverageRequired { get; set; }

        public string? CoverageCode { get; set; }

        public string? CoverageName { get; set; }

        public Guid? CoverageId { get; set; }

        public bool? IsMainCoverage { get; set; }

        public string? ObjectCode { get; set; }

        public string? ObjectName { get; set; }

        public Guid? ObjectId { get; set; }

        public bool? IsMainObject { get; set; }

        public bool? IsPrivate { get; set; }

        public bool? IsBusiness { get; set; }

        public string? DamageReasonCode { get; set; }

        public string? DamageReasonName { get; set; }

        public Guid? DamageReasonId { get; set; }

        public bool? IsMainDamageReason { get; set; }
    }
}