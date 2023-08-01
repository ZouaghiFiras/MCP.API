namespace CED.Data.Entities
{
    public class PurchaseBacklogsPendingEntryCountView
    {
        public int Id { get; set; }

        public string? EntrySystem { get; set; }

        public int? RecordCount { get; set; }

        public int? UrgentCount { get; set; }
    }
}