namespace CED.Data.Entities
{
    public class PaymentBatchLine
    {
        public Guid PblId { get; set; }

        public byte[] PblTimeStamp { get; set; } = null!;

        public Guid PblPaymentBatchId { get; set; }

        public Guid PblCreditTransferId { get; set; }

        public int PblSequenceNumber { get; set; }

        public DateTime PblCreatedDate { get; set; }

        public string? PblCreatedBy { get; set; }

        public DateTime PblLastModifiedDate { get; set; }

        public string? PblLastModifiedBy { get; set; }

        public virtual CreditTransfer PblCreditTransfer { get; set; } = null!;

        public virtual PaymentBatch PblPaymentBatch { get; set; } = null!;
    }
}