namespace CED.Data.Entities
{
    public class PurchaseBacklogsPendingInvestigationCountView
    {
        public int Id { get; set; }

        public string? EntrySystem { get; set; }

        public int? RecordCount { get; set; }

        public int? UrgentCount { get; set; }
    }
}