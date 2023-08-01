namespace CED.Data.Entities
{
    public class JournalGeneralLedgerBalancesView
    {
        public string Id { get; set; } = null!;

        public string Gldescription { get; set; } = null!;

        public string? ExactLedgerAccount { get; set; }

        public bool IsPrimaryProcess { get; set; }

        public bool IsSuspenseAccount { get; set; }

        public bool IsProfitLossAccount { get; set; }

        public int? GlnumberOfLines { get; set; }

        public decimal? GltotalCreditValue { get; set; }

        public decimal? GltotalDebitValue { get; set; }

        public string JournalId { get; set; } = null!;

        public string? JournalAbbreviation { get; set; }

        public string JournalDescription { get; set; } = null!;

        public string CurrencyCode { get; set; } = null!;

        public string JournalTypeId { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public string? ExactJournal { get; set; }

        public short? ExactJournalType { get; set; }

        public string ExactJournalDescription { get; set; } = null!;

        public int? JournalNumberOfLines { get; set; }

        public decimal? JournalTotalCreditValue { get; set; }

        public decimal? JournalTotalDebitValue { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}