namespace CED.Data.Entities
{
    public class ReconcilliationBankAccountsView
    {
        public Guid Id { get; set; }

        public string AccountNumber { get; set; } = null!;

        public string? Iban { get; set; }

        public string? ExactAdministration { get; set; }

        public string? ExactJournal { get; set; }

        public string LedgerAccount { get; set; } = null!;

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}