namespace CED.Data.Entities
{
    public class CreditTransfersPayReadyPurchaseInvoicesView
    {
        public Guid PaymentId { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string PaymentNumber { get; set; } = null!;

        public Guid BankAccountId { get; set; }

        public decimal CreditAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? ExecutionDate { get; set; }

        public bool UrgentTransfer { get; set; }

        public string? RecipientName { get; set; }

        public string? RecipientIban { get; set; }

        public string? RecipientBic { get; set; }

        public string? RemittanceInformation { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public bool? IsSelected { get; set; }

        public string? SelectedBy { get; set; }

        public decimal InvoiceNetAmount { get; set; }

        public decimal? SignedAmount { get; set; }

        public bool IsCredit { get; set; }

        public string? YourReference { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string? OurReference { get; set; }

        public string? Description { get; set; }

        public string? DossierNumber { get; set; }

        public string? LeadCurrencyCode { get; set; }

        public string? PaymentCurrencyCode { get; set; }

        public string PaymentBatchType { get; set; } = null!;

        public string? SupplierInvoiceNumber { get; set; }

        public string SupplierName { get; set; } = null!;

        public string? SupplierCode { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}