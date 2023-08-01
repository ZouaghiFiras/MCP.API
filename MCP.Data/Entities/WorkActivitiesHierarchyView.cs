namespace CED.Data.Entities
{
    public class WorkActivitiesHierarchyView
    {
        public string MainActivityCode { get; set; } = null!;

        public string? MainActivityName { get; set; }

        public bool MainActivityIsMain { get; set; }

        public string? SubActivityCode { get; set; }

        public string? SubActivityName { get; set; }

        public bool? SubActivityIsMain { get; set; }

        public string? TertiaryActivityCode { get; set; }

        public string? TertiaryActivityName { get; set; }

        public bool? TertiaryActivityIsMain { get; set; }
    }
}