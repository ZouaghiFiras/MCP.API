namespace CED.Data.Entities
{
    public class CreditTransferJournalEntryLine
    {
        public Guid CjlId { get; set; }

        public byte[] CjlTimeStamp { get; set; } = null!;

        public Guid CjlCreditTransferId { get; set; }

        public Guid CjlJournalEntryLineId { get; set; }

        public Guid? CjlPurchaseInvoiceId { get; set; }

        public Guid? CjlSalesInvoiceId { get; set; }

        public DateTime CjlCreatedDate { get; set; }

        public string? CjlCreatedBy { get; set; }

        public DateTime CjlLastModifiedDate { get; set; }

        public string? CjlLastModifiedBy { get; set; }

        public virtual CreditTransfer CjlCreditTransfer { get; set; } = null!;

        public virtual JournalEntryLine CjlJournalEntryLine { get; set; } = null!;

        public virtual PurchaseInvoice? CjlPurchaseInvoice { get; set; }

        public virtual SalesInvoice? CjlSalesInvoice { get; set; }
    }
}