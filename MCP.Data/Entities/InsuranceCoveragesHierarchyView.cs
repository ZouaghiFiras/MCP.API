namespace CED.Data.Entities
{
    public class InsuranceCoveragesHierarchyView
    {
        public string ParentCoverageCode { get; set; } = null!;

        public bool ParentIsMain { get; set; }

        public string? ParentCoverageName { get; set; }

        public string? CoverageCode { get; set; }

        public string? CoverageName { get; set; }

        public bool? CoverageIsMain { get; set; }
    }
}