namespace CED.Data.Entities
{
    public class SalesJournalEntriesView
    {
        public Guid Id { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid JournalEntryId { get; set; }

        public DateTime JournalEntryDate { get; set; }

        public string? FinancialYear { get; set; }

        public string? FinancialPeriod { get; set; }

        public string? JournalNumber { get; set; }

        public string JournalEntryNumber { get; set; } = null!;

        public string JournalType { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}