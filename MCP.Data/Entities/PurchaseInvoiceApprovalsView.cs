namespace CED.Data.Entities
{
    public class PurchaseInvoiceApprovalsView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid PurchaseInvoiceAuthorizationId { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string CreditorNumber { get; set; } = null!;

        public string? CreditorIban { get; set; }

        public string? CreditorAccountName { get; set; }

        public string SupplierName { get; set; } = null!;

        public string? SupplierInvoiceNumber { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? YourReference { get; set; }

        public DateTime? PaymentDate { get; set; }

        public string? OurReference { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public decimal? OpenAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public Guid? PaymentConditionId { get; set; }

        public string? PaymentConditionCode { get; set; }

        public string? PaymentConditionName { get; set; }

        public Guid? PaymentMethodId { get; set; }

        public string? PaymentMethodCode { get; set; }

        public string? PaymentMethodName { get; set; }

        public string? ClientCode { get; set; }

        public string? ClientAbbreviation { get; set; }

        public string ClientName { get; set; } = null!;

        public bool IsRecipientLegalEntity { get; set; }

        public bool IsCredit { get; set; }

        public Guid? DebitPurchaseInvoiceId { get; set; }

        public string RecipientName { get; set; } = null!;

        public bool IsValidBankAccount { get; set; }

        public string? EntrySystem { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}