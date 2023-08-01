namespace CED.Data.Entities
{
    public class PurchasePaymentJournalEntryLine
    {
        public Guid UjlId { get; set; }

        public byte[] UjlTimeStamp { get; set; } = null!;

        public Guid UjlPurchasePaymentId { get; set; }

        public Guid UjlJournalEntryLineId { get; set; }

        public DateTime UjlCreatedDate { get; set; }

        public string? UjlCreatedBy { get; set; }

        public DateTime UjlLastModifiedDate { get; set; }

        public string? UjlLastModifiedBy { get; set; }

        public virtual JournalEntryLine UjlJournalEntryLine { get; set; } = null!;

        public virtual PurchasePayment UjlPurchasePayment { get; set; } = null!;
    }
}