namespace CED.Data.Entities
{
    public class RecoveryPaymentsView
    {
        public Guid Id { get; set; }

        public Guid RecoveryStatementId { get; set; }

        public string RecoveryStatementNumber { get; set; } = null!;

        public Guid BankId { get; set; }

        public string BankAccountNumber { get; set; } = null!;

        public int BankstatementNumber { get; set; }

        public int BankstatementLineNumber { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal PaymentValue { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string? RemittanceInformation { get; set; }

        public string? Notes { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string PaymentStatus { get; set; } = null!;

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}