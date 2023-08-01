namespace CED.Data.Entities
{
    public class JournalEntriesView
    {
        public Guid Id { get; set; }

        public string JournalNumber { get; set; } = null!;

        public DateTime JournalDate { get; set; }

        public string JournalId { get; set; } = null!;

        public string Description { get; set; } = null!;

        public bool Inactive { get; set; }

        public string? ExactAdministration { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? NumberOfLines { get; set; }

        public decimal? TotalCreditValue { get; set; }

        public decimal? TotalDebitValue { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}