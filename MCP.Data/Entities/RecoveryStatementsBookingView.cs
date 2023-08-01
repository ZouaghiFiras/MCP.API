namespace CED.Data.Entities
{
    public class RecoveryStatementsBookingView
    {
        public Guid Id { get; set; }

        public Guid? LegalEntityId { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string? JournalId { get; set; }

        public string? JournalNumber { get; set; }

        public DateTime? JournalDate { get; set; }

        public string? OurReference { get; set; }

        public string? YourReference { get; set; }

        public string? CreditorNumber { get; set; }

        public DateTime BankStatementDate { get; set; }

        public decimal? TransactionAmount { get; set; }

        public string? AccountHolderName { get; set; }

        public string? Iban { get; set; }

        public string? RemittanceInformation { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}