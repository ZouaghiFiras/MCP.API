namespace CED.Data.Entities
{
    public class BankJournalEntryLine
    {
        public Guid BjlId { get; set; }

        public byte[] BjlTimeStamp { get; set; } = null!;

        public Guid BjlBankJournalEntryId { get; set; }

        public Guid BjlBankStatementReconcilliationId { get; set; }

        public Guid BjlJournalEntryLineId { get; set; }

        public DateTime BjlCreatedDate { get; set; }

        public string? BjlCreatedBy { get; set; }

        public DateTime BjlLastModifiedDate { get; set; }

        public string? BjlLastModifiedBy { get; set; }

        public virtual BankJournalEntry BjlBankJournalEntry { get; set; } = null!;

        public virtual BankStatementReconcilliation BjlBankStatementReconcilliation { get; set; } = null!;

        public virtual JournalEntryLine BjlJournalEntryLine { get; set; } = null!;
    }
}