namespace CED.Data.Entities
{
    public class ProductCatalogViewProspectTest
    {
        public string ProductGroupCode { get; set; } = null!;

        public string ProductGroupName { get; set; } = null!;

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public string? Department { get; set; }

        public string? ActivityCode { get; set; }

        public string? ActivityName { get; set; }

        public bool? IsMainActivity { get; set; }

        public string? SubActivityCode { get; set; }

        public string? SubActivityName { get; set; }

        public bool? SubIsMainActivity { get; set; }

        public string? TerActivityCode { get; set; }

        public string? TerActivityName { get; set; }

        public bool? TerIsMainActivity { get; set; }

        public bool? IsEconomicLoss { get; set; }

        public bool? IsCoverageRequired { get; set; }

        public string? CoverageCode { get; set; }

        public string? CoverageName { get; set; }

        public bool? IsMainCoverage { get; set; }

        public string? ObjectCode { get; set; }

        public string? ObjectName { get; set; }

        public bool? IsMainObject { get; set; }

        public bool? IsPrivate { get; set; }

        public bool? IsBusiness { get; set; }

        public string? DamageReasonCode { get; set; }

        public string? DamageReasonName { get; set; }

        public bool? IsMainDamageReason { get; set; }
    }
}