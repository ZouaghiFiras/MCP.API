namespace CED.Data.Entities
{
    public class JournalEntriesPendingExportView
    {
        public Guid Id { get; set; }

        public string JournalNumber { get; set; } = null!;

        public DateTime JournalDate { get; set; }

        public string JournalId { get; set; } = null!;

        public string JournalTypeId { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public DateTime? ExactExportDate { get; set; }

        public string? JournalEntryStatusCode { get; set; }

        public string? JournalEntryStatusName { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}