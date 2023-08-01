namespace CED.Data.Entities
{
    public class PurchaseInvoicesPendingAuthorizationCountView
    {
        public int Id { get; set; }

        public string? EntrySystem { get; set; }

        public int? RecordCount { get; set; }

        public int? UrgentCount { get; set; }
    }
}