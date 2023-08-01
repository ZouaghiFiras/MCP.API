namespace CED.Data.Entities
{
    public class TransferJournalEntry
    {
        public Guid JournalEntryId { get; set; }

        public string JournalEntryNumber { get; set; } = null!;

        public short JournalEntryStatus { get; set; }

        public string? ErrorMessage { get; set; }
    }
}