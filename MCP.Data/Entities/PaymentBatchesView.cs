namespace CED.Data.Entities
{
    public class PaymentBatchesView
    {
        public Guid Id { get; set; }

        public string BatchNumber { get; set; } = null!;

        public DateTime PaymentDateUntil { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public string JournalId { get; set; } = null!;

        public string JournalName { get; set; } = null!;

        public string JournalCurrencyCode { get; set; } = null!;

        public string? ExactJournal { get; set; }

        public string? ExactAdministration { get; set; }

        public Guid BankAccountId { get; set; }

        public string? BankAccountAbbreviation { get; set; }

        public string BankAccountName { get; set; } = null!;

        public string? BankAccountIban { get; set; }

        public string BankAccountCurrencyCode { get; set; } = null!;

        public bool IsExecuted { get; set; }

        public DateTime? BankStatementDate { get; set; }

        public int NumberOfLines { get; set; }

        public decimal CreditAmount { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}