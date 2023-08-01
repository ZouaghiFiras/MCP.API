namespace CED.Data.Entities
{
    public class SalesInvoicesPendingExportView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string InvoiceNumber { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryBatch { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TaxExemptedAmount { get; set; }

        public decimal TaxReversedChargeAmount { get; set; }

        public decimal TaxImportAmount { get; set; }

        public decimal NetAmount { get; set; }

        public decimal? OpenAmount { get; set; }

        public DateTime? DueDate { get; set; }

        public string? CurrencyCode { get; set; }

        public double? ExchangeRate { get; set; }

        public bool IsPrinted { get; set; }

        public bool IsFiscalised { get; set; }

        public bool IsImported { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public Guid DebtorId { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public string DebtorName { get; set; } = null!;

        public string? DebtorStreetName { get; set; }

        public string? DebtorHouseNo { get; set; }

        public string? DebtorHouseNoAddition { get; set; }

        public string? DebtorPostalCode { get; set; }

        public string? DebtorCity { get; set; }

        public string? DebtorCountryCode { get; set; }

        public string? DebtorVatNumber { get; set; }

        public string? DebtorIban { get; set; }

        public string? DebtorEmailAddress { get; set; }

        public bool IsIntercompany { get; set; }

        public bool IsCredit { get; set; }

        public string? DebitEntryNumber { get; set; }

        public string? CultureCode { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? EmployeeName { get; set; }

        public string? JournalId { get; set; }

        public string? JournalName { get; set; }

        public string? BookingNumber { get; set; }

        public DateTime? BookingDate { get; set; }

        public Guid? CostCenterId { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostCenterName { get; set; }

        public Guid? CostUnitId { get; set; }

        public string? CostUnitCode { get; set; }

        public string? CostUnitName { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DocumentArchiveId { get; set; }

        public string? PaymentReference { get; set; }

        public string? SalesInvoiceStatusCode { get; set; }

        public string? SalesInvoiceStatusName { get; set; }

        public string? InvoiceDeliveryMethod { get; set; }

        public string? InvoiceDeliveryMethodType { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}