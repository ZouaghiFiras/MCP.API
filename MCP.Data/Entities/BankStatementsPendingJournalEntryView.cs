namespace CED.Data.Entities
{
    public class BankStatementsPendingJournalEntryView
    {
        public Guid Id { get; set; }

        public string TransactionReferenceNumber { get; set; } = null!;

        public string? ReferenceToRelatedTransaction { get; set; }

        public Guid BankAccountId { get; set; }

        public int StatementYear { get; set; }

        public int StatementNumber { get; set; }

        public int SequenceNumber { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public DateTime OpeningBalanceDate { get; set; }

        public decimal OpeningBalanceValue { get; set; }

        public DateTime ClosingBalanceDate { get; set; }

        public decimal ClosingBalanceValue { get; set; }

        public string? MessageDescription { get; set; }

        public string? Mt940 { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}