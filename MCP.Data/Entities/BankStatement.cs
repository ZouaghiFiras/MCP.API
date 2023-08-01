namespace CED.Data.Entities
{
    public class BankStatement
    {
        public Guid BsnId { get; set; }

        public byte[] BsnTimeStamp { get; set; } = null!;

        public string BsnTransactionReferenceNumber { get; set; } = null!;

        public string? BsnReferenceToRelatedTransaction { get; set; }

        public Guid BsnBankAccountId { get; set; }

        public int BsnStatementYear { get; set; }

        public int BsnStatementNumber { get; set; }

        public int BsnSequenceNumber { get; set; }

        public string BsnCurrencyCode { get; set; } = null!;

        public DateTime BsnOpeningBalanceDate { get; set; }

        public decimal BsnOpeningBalanceValue { get; set; }

        public DateTime BsnClosingBalanceDate { get; set; }

        public decimal BsnClosingBalanceValue { get; set; }

        public string? BsnMessageDescription { get; set; }

        public string? BsnMt940 { get; set; }

        public DateTime BsnCreatedDate { get; set; }

        public string? BsnCreatedBy { get; set; }

        public DateTime BsnLastModifiedDate { get; set; }

        public string? BsnLastModifiedBy { get; set; }

        public Guid? BsnCurrentStatusHistoryId { get; set; }

        public DateTime? BsnCurrentStatusHistoryStartDate { get; set; }

        public string? BsnCurrentStatusCode { get; set; }

        public virtual ICollection<BankJournalEntry> BankJournalEntries { get; } = new List<BankJournalEntry>();

        public virtual ICollection<BankStatementAttachment> BankStatementAttachments { get; } =
            new List<BankStatementAttachment>();

        public virtual ICollection<BankStatementLine> BankStatementLines { get; } = new List<BankStatementLine>();

        public virtual ICollection<BankStatementStatusHistory> BankStatementStatusHistories { get; } =
            new List<BankStatementStatusHistory>();

        public virtual BankAccount BsnBankAccount { get; set; } = null!;
    }
}