namespace CED.Data.Entities
{
    public class LatestBankStatementsView
    {
        public Guid? Id { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string JournalId { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public string? ExactJournal { get; set; }

        public Guid BankAccountId { get; set; }

        public string AccountName { get; set; } = null!;

        public string? Iban { get; set; }

        public int? StatementNumber { get; set; }

        public int? SequenceNumber { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? OpeningBalanceDate { get; set; }

        public decimal? OpeningBalanceValue { get; set; }

        public DateTime? ClosingBalanceDate { get; set; }

        public decimal? ClosingBalanceValue { get; set; }

        public Guid? BankStatementId { get; set; }

        public bool IsReconciled { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[]? TimeStamp { get; set; }
    }
}