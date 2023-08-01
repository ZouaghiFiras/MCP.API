namespace CED.Data.Entities
{
    public class BankJournalEntry
    {
        public Guid BjeId { get; set; }

        public byte[] BjeTimeStamp { get; set; } = null!;

        public Guid BjeBankStatementId { get; set; }

        public Guid BjeJournalEntryId { get; set; }

        public DateTime BjeCreatedDate { get; set; }

        public string? BjeCreatedBy { get; set; }

        public DateTime BjeLastModifiedDate { get; set; }

        public string? BjeLastModifiedBy { get; set; }

        public virtual ICollection<BankJournalEntryLine> BankJournalEntryLines { get; } =
            new List<BankJournalEntryLine>();

        public virtual BankStatement BjeBankStatement { get; set; } = null!;

        public virtual JournalEntry BjeJournalEntry { get; set; } = null!;
    }
}