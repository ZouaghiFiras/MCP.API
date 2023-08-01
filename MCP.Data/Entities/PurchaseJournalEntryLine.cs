namespace CED.Data.Entities
{
    public class PurchaseJournalEntryLine
    {
        public Guid PjlId { get; set; }

        public byte[] PjlTimeStamp { get; set; } = null!;

        public Guid PjlPurchaseInvoiceLineId { get; set; }

        public Guid PjlJournalEntryLineId { get; set; }

        public DateTime PjlCreatedDate { get; set; }

        public string? PjlCreatedBy { get; set; }

        public DateTime PjlLastModifiedDate { get; set; }

        public string? PjlLastModifiedBy { get; set; }

        public virtual JournalEntryLine PjlJournalEntryLine { get; set; } = null!;

        public virtual PurchaseInvoiceLine PjlPurchaseInvoiceLine { get; set; } = null!;
    }
}