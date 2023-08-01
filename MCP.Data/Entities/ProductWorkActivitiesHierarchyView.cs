namespace CED.Data.Entities
{
    public class ProductWorkActivitiesHierarchyView
    {
        public string ProductTypeCode { get; set; } = null!;

        public string? ProductTypeName { get; set; }

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public string? MainActivityCode { get; set; }

        public string? MainActivityName { get; set; }

        public bool? MainActivityIsMain { get; set; }

        public string? SubActivityCode { get; set; }

        public string? SubActivityName { get; set; }

        public bool? SubActivityIsMain { get; set; }

        public string? TertiaryActivityCode { get; set; }

        public string? TertiaryActivityName { get; set; }

        public bool? TertiaryActivityIsMain { get; set; }
    }
}