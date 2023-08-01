namespace CED.Data.Entities
{
    public class JournalEntry
    {
        public Guid JreId { get; set; }

        public byte[] JreTimeStamp { get; set; } = null!;

        public string JreJournalNumber { get; set; } = null!;

        public DateTime JreJournalDate { get; set; }

        public string JreJournalId { get; set; } = null!;

        public string? JreExactAdministration { get; set; }

        public DateTime? JreExactExportDate { get; set; }

        public DateTime JreCreatedDate { get; set; }

        public string? JreCreatedBy { get; set; }

        public DateTime JreLastModifiedDate { get; set; }

        public string? JreLastModifiedBy { get; set; }

        public Guid? JreCurrentStatusHistoryId { get; set; }

        public DateTime? JreCurrentStatusHistoryStartDate { get; set; }

        public string? JreCurrentStatusCode { get; set; }

        public string? JreJournalCurrencyCode { get; set; }

        public string? JreLeadCurrencyCode { get; set; }

        public decimal? JreDebitValue { get; set; }

        public decimal? JreCreditValue { get; set; }

        public string? JreForeignCurrencyCode { get; set; }

        public decimal? JreForeignDebitValue { get; set; }

        public decimal? JreForeignCreditValue { get; set; }

        public double? JreExchangeRate { get; set; }

        public Guid? JreExchangeRateId { get; set; }

        public virtual ICollection<BankJournalEntry> BankJournalEntries { get; } = new List<BankJournalEntry>();

        public virtual ICollection<JournalEntryLine> JournalEntryLines { get; } = new List<JournalEntryLine>();

        public virtual ICollection<JournalEntryStatusHistory> JournalEntryStatusHistories { get; } =
            new List<JournalEntryStatusHistory>();

        public virtual ExchangeRate? JreExchangeRateNavigation { get; set; }

        public virtual Journal JreJournal { get; set; } = null!;
    }
}