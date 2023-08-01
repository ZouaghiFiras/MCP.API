namespace CED.Data.Entities
{
    public class PurchaseInvoiceSummariesView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public bool IsCredit { get; set; }

        public string? EntrySystem { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TaxExemptedAmount { get; set; }

        public decimal TaxImportAmount { get; set; }

        public decimal TaxResversedChargeAmount { get; set; }

        public decimal NetAmount { get; set; }

        public string? TaxCountryCode { get; set; }

        public decimal? OpenAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public double? ExchangeRate { get; set; }

        public string? PaymentCurrencyCode { get; set; }

        public double? PaymentExchangeRate { get; set; }

        public decimal? ConvertedGrossAmount { get; set; }

        public decimal? ConvertedTaxAmount { get; set; }

        public decimal? ConvertedNetAmount { get; set; }

        public Guid LegalEntityId { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string CreditorNumber { get; set; } = null!;

        public string CreditorName { get; set; } = null!;

        public string? CreditorPostalCode { get; set; }

        public string? CreditorCity { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? ClientId { get; set; }

        public string? Journal { get; set; }

        public string? LedgerAccount { get; set; }

        public string? SupplierVatNumber { get; set; }

        public string? SupplierNumber { get; set; }

        public string? SupplierName { get; set; }

        public string? PurchaseInvoiceStatusCode { get; set; }

        public string? PurchaseInvoiceStatusName { get; set; }

        public DateTime? PurchaseInvoiceStatusCreatedDate { get; set; }

        public Guid? DocumentArchiveId { get; set; }

        public string? SourceTypeId { get; set; }

        public bool IsUrgent { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? DossierAssignmentNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string? DepartmentName { get; set; }
    }
}