namespace CED.Data.Entities
{
    public class BankStatementJournalEntryLinesView
    {
        public Guid Id { get; set; }

        public Guid JournalEntryId { get; set; }

        public Guid BankStatementId { get; set; }

        public string JournalNumber { get; set; } = null!;

        public int SequenceNumber { get; set; }

        public string? Description { get; set; }

        public string GeneralLedgerDescription { get; set; } = null!;

        public DateTime? Date { get; set; }

        public string LedgerAccount { get; set; } = null!;

        public string? DebtorNumber { get; set; }

        public string? CreditorNumber { get; set; }

        public string? InvoiceNumber { get; set; }

        public decimal? DebitValue { get; set; }

        public decimal? CreditValue { get; set; }

        public string? CurrencyCode { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}