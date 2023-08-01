namespace CED.Data.Entities
{
    public class PurchaseJournalEntriesExactExportedView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public DateTime JournalEntryDate { get; set; }

        public string JournalEntryNumber { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}