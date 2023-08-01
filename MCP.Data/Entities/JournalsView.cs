namespace CED.Data.Entities
{
    public class JournalsView
    {
        public string Id { get; set; } = null!;

        public string? Abbreviation { get; set; }

        public string Description { get; set; } = null!;

        public string CurrencyCode { get; set; } = null!;

        public string GeneralLedgerId { get; set; } = null!;

        public string JournalTypeId { get; set; } = null!;

        public short? ExactJournalType { get; set; }

        public string? ExactAdministration { get; set; }

        public string? ExactJournal { get; set; }

        public Guid LegalEntityId { get; set; }

        public bool Inactive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}