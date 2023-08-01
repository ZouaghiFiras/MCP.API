namespace CED.Data.Entities
{
    public class BankStatementReconcilliationsReport
    {
        public string Journal { get; set; } = null!;

        public string EntryNumber { get; set; } = null!;

        public string? Iban { get; set; }

        public string Currency { get; set; } = null!;

        public DateTime StatementDate { get; set; }

        public int StatementNumber { get; set; }

        public decimal OpeningAmount { get; set; }

        public decimal ClosingAmount { get; set; }

        public int LineNumber { get; set; }

        public decimal TransactionValue { get; set; }

        public decimal MatchValue { get; set; }

        public bool? PartialMatch { get; set; }

        public string LedgerAccount { get; set; } = null!;

        public string? RecoveryNumber { get; set; }

        public string? SalesInvoiceNumber { get; set; }

        public string? PurchaseInvoiceNumber { get; set; }

        public string? Description { get; set; }

        public string? YourRef { get; set; }

        public string? OurRef { get; set; }

        public decimal? DebitValue { get; set; }

        public decimal? CreditValue { get; set; }

        public string? DebtorNumber { get; set; }

        public string? CreditorNumber { get; set; }

        public string? InvoiceNumber { get; set; }

        public Guid BankStatementId { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}