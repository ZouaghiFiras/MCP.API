namespace CED.Data.Entities
{
    public class PurchaseInvoicesBlockedUnmatchedCountView
    {
        public int Id { get; set; }

        public string? EntrySystem { get; set; }

        public int? RecordCount { get; set; }

        public Guid LegalEntityId { get; set; }

        public int? UrgentCount { get; set; }
    }
}