namespace CED.Data.Entities
{
    public class PurchaseInvoicePaymentAuthorizationsView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid LegalEntityId { get; set; }

        public string? EntrySystem { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

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

        public Guid? PaymentMethodId { get; set; }

        public string? PaymentMethodCode { get; set; }

        public string? PaymentMethodName { get; set; }

        public string? DocumentArchiveId { get; set; }

        public bool IsSelected { get; set; }

        public bool IsApproved { get; set; }

        public bool IsRejected { get; set; }

        public string? ApprovalComment { get; set; }

        public string? SelectedBy { get; set; }

        public bool IsRecipientLegalEntity { get; set; }

        public bool IsCredit { get; set; }

        public Guid? DebitPurchaseInvoiceId { get; set; }

        public string RecipientName { get; set; } = null!;

        public bool? IsValidBankAccount { get; set; }

        public bool? IsCostOfSales { get; set; }

        public bool IsBlockedForPaymentAuthorization { get; set; }

        public bool IsUrgent { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public bool? IsValid { get; set; }
    }
}