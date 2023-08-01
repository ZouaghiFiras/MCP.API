namespace CED.Data.Entities
{
    public class GeneralJournalEntriesExactView
    {
        public Guid Id { get; set; }

        public string JournalId { get; set; } = null!;

        public string JournalTypeId { get; set; } = null!;

        public Guid LegalEntityId { get; set; }

        public string? ExactJournal { get; set; }

        public string? ExactGeneralLedger { get; set; }

        public string? ExactAdministration { get; set; }

        public DateTime JournalEntryDate { get; set; }

        public string JournalEntryNumber { get; set; } = null!;

        public int? FinancialYear { get; set; }

        public int? FinancialPeriod { get; set; }

        public DateTime? ExactExportDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}