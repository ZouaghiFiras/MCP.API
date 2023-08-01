namespace CED.Data.Entities
{
    public class PaymentBatch
    {
        public Guid PybId { get; set; }

        public byte[] PybTimeStamp { get; set; } = null!;

        public string PybBatchNumber { get; set; } = null!;

        public DateTime PybPaymentDateUntil { get; set; }

        public Guid PybOrganizationAccountId { get; set; }

        public DateTime PybCreatedDate { get; set; }

        public string? PybCreatedBy { get; set; }

        public DateTime PybLastModifiedDate { get; set; }

        public string? PybLastModifiedBy { get; set; }

        public virtual ICollection<BankStatementLine> BankStatementLines { get; } = new List<BankStatementLine>();

        public virtual ICollection<PaymentBatchLine> PaymentBatchLines { get; } = new List<PaymentBatchLine>();

        public virtual OrganizationAccount PybOrganizationAccount { get; set; } = null!;
    }
}