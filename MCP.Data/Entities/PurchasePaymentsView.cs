namespace CED.Data.Entities
{
    public class PurchasePaymentsView
    {
        public Guid? Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public Guid? BankId { get; set; }

        public string? BankAccountNumber { get; set; }

        public int? BankstatementNumber { get; set; }

        public int? BankstatementLineNumber { get; set; }

        public DateTime? PaymentDate { get; set; }

        public string? CurrencyCode { get; set; }

        public string? RemittanceInformation { get; set; }

        public Guid? PaymentBatchId { get; set; }

        public string? Notes { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string? BankAccountHolderName { get; set; }

        public decimal? PaymentValue { get; set; }

        public string PaymentStatus { get; set; } = null!;

        public string? DebtorNumber { get; set; }

        public string? CreditorNumber { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public Guid? SupplierId { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string? ToIban { get; set; }

        public string? ToAccountNumber { get; set; }

        public string? ToBic { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public byte[]? TimeStamp { get; set; }
    }
}