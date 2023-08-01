namespace CED.Data.Entities
{
    public class PurchasePayment
    {
        public Guid PipId { get; set; }

        public byte[] PipTimeStamp { get; set; } = null!;

        public Guid PipPurchaseInvoiceId { get; set; }

        public Guid PipBankStatementLineId { get; set; }

        public decimal PipPaymentValue { get; set; }

        public DateTime PipCreatedDate { get; set; }

        public string? PipCreatedBy { get; set; }

        public DateTime PipLastModifiedDate { get; set; }

        public string? PipLastModifiedBy { get; set; }

        public Guid? PipCurrentStatusHistoryId { get; set; }

        public DateTime? PipCurrentStatusHistoryStartDate { get; set; }

        public string? PipCurrentStatusCode { get; set; }

        public virtual BankStatementLine PipBankStatementLine { get; set; } = null!;

        public virtual PurchaseInvoice PipPurchaseInvoice { get; set; } = null!;

        public virtual ICollection<PurchasePaymentJournalEntryLine> PurchasePaymentJournalEntryLines { get; } =
            new List<PurchasePaymentJournalEntryLine>();

        public virtual ICollection<PurchasePaymentStatusHistory> PurchasePaymentStatusHistories { get; } =
            new List<PurchasePaymentStatusHistory>();
    }
}