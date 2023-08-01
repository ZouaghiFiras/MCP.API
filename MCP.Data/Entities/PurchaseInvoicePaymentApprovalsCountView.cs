namespace CED.Data.Entities
{
    public class PurchaseInvoicePaymentApprovalsCountView
    {
        public int Id { get; set; }

        public string? EntrySystem { get; set; }

        public int? RecordCount { get; set; }

        public int? UrgentCount { get; set; }
    }
}