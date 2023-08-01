namespace CED.Data.Entities
{
    public class BankStatementsReconcilableView
    {
        public Guid Id { get; set; }

        public string? Iban { get; set; }

        public string AccountName { get; set; } = null!;

        public string? AccountAbbreviation { get; set; }

        public Guid BankAccountId { get; set; }

        public string TransactionReferenceNumber { get; set; } = null!;

        public string? ReferenceToRelatedTransaction { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public int StatementNumber { get; set; }

        public int SequenceNumber { get; set; }

        public DateTime OpeningBalanceDate { get; set; }

        public decimal OpeningBalanceValue { get; set; }

        public DateTime ClosingBalanceDate { get; set; }

        public decimal ClosingBalanceValue { get; set; }

        public string? MessageDescription { get; set; }

        public string JournalCode { get; set; } = null!;

        public bool IsNextToReconcile { get; set; }

        public bool HasCorrections { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public bool HasDocuments { get; set; }

        public bool IsReconcilliationAllowed { get; set; }

        public int NumberOfLines { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}