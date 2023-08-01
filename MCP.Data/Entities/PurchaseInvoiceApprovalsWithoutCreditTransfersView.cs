namespace CED.Data.Entities
{
    public class PurchaseInvoiceApprovalsWithoutCreditTransfersView
    {
        public Guid CreditTransferId { get; set; }

        public string? CreditTransferNumber { get; set; }

        public Guid? BankAccountId { get; set; }

        public decimal? CreditAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? ExecutionDate { get; set; }

        public bool? UrgentTransfer { get; set; }

        public string? AccountNumber { get; set; }

        public string? AccountHolderName { get; set; }

        public string? AccountAddressLine1 { get; set; }

        public string? AccountAddressLine2 { get; set; }

        public string? BankName { get; set; }

        public string? Iban { get; set; }

        public string? Bic { get; set; }

        public string? RemittanceInformation { get; set; }

        public string EntrySystem { get; set; } = null!;

        public Guid EntryNumber { get; set; }

        public int? EntryBatch { get; set; }

        public int? CanceledCreditTransferId { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public Guid PurchaseInvoiceId { get; set; }

        public bool IsApproved { get; set; }
    }
}