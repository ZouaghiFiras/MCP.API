namespace CED.Data.Entities
{
    public class PaymentBatchLinesView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public Guid BankAccountId { get; set; }

        public decimal CreditAmount { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public DateTime? ExecutionDate { get; set; }

        public bool UrgentTransfer { get; set; }

        public string? AccountNumber { get; set; }

        public string? AccountHolderName { get; set; }

        public string? AccountAddressLine1 { get; set; }

        public string? AccountAddressLine2 { get; set; }

        public string? BankName { get; set; }

        public string? Iban { get; set; }

        public string? Bic { get; set; }

        public string? RemittanceInformation { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }

        public Guid? TenantId { get; set; }

        public Guid PaymentBatchId { get; set; }

        public string PaymentBatchNumber { get; set; } = null!;

        public int PaymentBatchLine { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}