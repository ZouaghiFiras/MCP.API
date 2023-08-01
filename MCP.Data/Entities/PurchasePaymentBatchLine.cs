namespace CED.Data.Entities
{
    public class PurchasePaymentBatchLine
    {
        public Guid PplId { get; set; }

        public byte[] PplTimeStamp { get; set; } = null!;

        public Guid PplPurchasePaymentBatchId { get; set; }

        public int PplSequenceNumber { get; set; }

        public Guid PplPurchaseInvoiceId { get; set; }

        public decimal PplPaymentAmount { get; set; }

        public Guid PplCreditTransferId { get; set; }

        public DateTime PplCreatedDate { get; set; }

        public string? PplCreatedBy { get; set; }

        public DateTime PplLastModifiedDate { get; set; }

        public string? PplLastModifiedBy { get; set; }

        public virtual CreditTransfer PplCreditTransfer { get; set; } = null!;

        public virtual PurchaseInvoice PplPurchaseInvoice { get; set; } = null!;

        public virtual PurchasePaymentBatch PplPurchasePaymentBatch { get; set; } = null!;
    }
}