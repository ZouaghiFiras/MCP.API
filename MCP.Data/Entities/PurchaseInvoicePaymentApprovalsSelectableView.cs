namespace CED.Data.Entities
{
    public class PurchaseInvoicePaymentApprovalsSelectableView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid? BankAccountId { get; set; }

        public decimal? CreditAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? ExecutionDate { get; set; }

        public bool? UrgentTransfer { get; set; }

        public string? AccountNumber { get; set; }

        public string? AccountHolderName { get; set; }

        public string? AccountAddressLine1 { get; set; }

        public string? AccountAddressLine2 { get; set; }

        public string? CountryCode { get; set; }

        public string? BankName { get; set; }

        public Guid? BankId { get; set; }

        public string? Iban { get; set; }

        public string? Bic { get; set; }

        public string? RemittanceInformation { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public bool? IsSelected { get; set; }

        public string? SelectedBy { get; set; }

        public string? EntrySystem { get; set; }

        public Guid EntryNumber { get; set; }

        public int? EntryBatch { get; set; }

        public int? CanceledCreditTransferId { get; set; }

        public Guid? TenantId { get; set; }

        public bool IsCredit { get; set; }

        public string? YourReference { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string? OurReference { get; set; }

        public string? Description { get; set; }

        public string? DossierNumber { get; set; }

        public string? LeadCurrencyCode { get; set; }

        public decimal? LeadAmount { get; set; }

        public double? ExchangeRate { get; set; }

        public string? PaymentCurrencyCode { get; set; }

        public string? PaymentBatchType { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string SupplierName { get; set; } = null!;

        public string? SupplierCode { get; set; }

        public Guid? SupplierId { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public string CreditorName { get; set; } = null!;

        public Guid CreditorId { get; set; }

        public bool? IsCostOfSales { get; set; }

        public string PurchaseInvoiceSalesStatus { get; set; } = null!;

        public bool IsBlockedForPaymentApproval { get; set; }

        public bool IsBankAccountInactive { get; set; }

        public bool? IsBankAccountValidated { get; set; }

        public bool IsBankAccountApproved { get; set; }

        public bool? IsInGeneralLedgerSystem { get; set; }

        public bool IsApproved { get; set; }

        public bool? IsSepaBankAccount { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}