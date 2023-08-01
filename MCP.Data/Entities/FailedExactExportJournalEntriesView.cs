namespace CED.Data.Entities
{
    public class FailedExactExportJournalEntriesView
    {
        public Guid Id { get; set; }

        public string JournalEntryNumber { get; set; } = null!;

        public DateTime JournalEntryDate { get; set; }

        public string JournalId { get; set; } = null!;

        public string JournalTypeId { get; set; } = null!;

        public decimal? TotalDebitValue { get; set; }

        public decimal? TotalCreditValue { get; set; }

        public string? ExactAdministration { get; set; }

        public string? ExactJournal { get; set; }

        public DateTime? ExactExportDate { get; set; }

        public string? StatusCode { get; set; }

        public string? StatusName { get; set; }

        public DateTime? StatusDate { get; set; }

        public string? StatusChangeReason { get; set; }

        public string? DossierNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? EntrySystem { get; set; }
    }
}