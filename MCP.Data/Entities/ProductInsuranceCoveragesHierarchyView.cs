namespace CED.Data.Entities
{
    public class ProductInsuranceCoveragesHierarchyView
    {
        public string ProductCode { get; set; } = null!;

        public string? ProductShortName { get; set; }

        public string? MainCoverageCode { get; set; }

        public string? MainCoverageName { get; set; }

        public string? SubCoverageCode { get; set; }

        public string? SubCoverageName { get; set; }
    }
}