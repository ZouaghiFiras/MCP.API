namespace CED.Data.Entities
{
    public class DraftSuppliersCountView
    {
        public string EntrySystem { get; set; } = null!;

        public int? TotalCount { get; set; }

        public int? TodayCount { get; set; }
    }
}