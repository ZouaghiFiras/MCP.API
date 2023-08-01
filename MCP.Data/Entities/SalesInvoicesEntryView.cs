namespace CED.Data.Entities
{
    public class SalesInvoicesEntryView
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

        public string? TaxCountryCode { get; set; }

        public decimal NetAmount { get; set; }

        public decimal? OpenAmount { get; set; }

        public DateTime? DueDate { get; set; }

        public string? LeadCurrencyCode { get; set; }

        public string? CurrencyCode { get; set; }

        public double? ExchangeRate { get; set; }

        public bool IsPrinted { get; set; }

        public bool IsFiscalised { get; set; }

        public bool IsImported { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public Guid? OrganizationUnitId { get; set; }

        public string? DepartmentCode { get; set; }

        public string? DepartmentName { get; set; }

        public string? BusinessUnitCode { get; set; }

        public string? BusinessUnitName { get; set; }

        public Guid InvoiceTypeId { get; set; }

        public string? InvoiceTypeCode { get; set; }

        public string? InvoiceTypeName { get; set; }

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

        public string? DebtorBic { get; set; }

        public string? DebtorChamberOfCommerceNumber { get; set; }

        public string? DebtorEmail { get; set; }

        public bool IsIntercompany { get; set; }

        public Guid? PaymentConditionId { get; set; }

        public string? PaymentConditionCode { get; set; }

        public string? PaymentConditionName { get; set; }

        public Guid? PaymentMethodId { get; set; }

        public string? PaymentMethodCode { get; set; }

        public string? PaymentMethodName { get; set; }

        public bool IsCredit { get; set; }

        public string? DebitEntryNumber { get; set; }

        public Guid? DebitInvoiceId { get; set; }

        public decimal? BlockedAmount { get; set; }

        public string? BlockedIban { get; set; }

        public string? BlockedBic { get; set; }

        public Guid? TenantId { get; set; }

        public string? TenantName { get; set; }

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

        public Guid? DossierAssignmentId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public Guid? DossierPartyId { get; set; }

        public string? DossierPartyName { get; set; }

        public string? DocumentArchiveId { get; set; }

        public string? PaymentReference { get; set; }

        public string? SalesInvoiceStatusCode { get; set; }

        public string? SalesInvoiceStatusName { get; set; }

        public string? SalesInvoiceStatusReason { get; set; }

        public string? InvoiceDeliveryMethod { get; set; }

        public string? SalesCollectionNumber { get; set; }

        public Guid? SalesCollectionId { get; set; }

        public bool IsCollectable { get; set; }

        public DateTime? CollectableDate { get; set; }

        public DateTime? SalesCollectionDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public string? VatNumber { get; set; }

        public Guid? VatDeductableId { get; set; }

        public string? OwnRiskNumber { get; set; }

        public Guid? OwnRiskId { get; set; }

        public string? OriginalSalesInvoiceNumber { get; set; }

        public Guid? OriginalSalesInvoiceId { get; set; }

        public decimal? OwnRiskAmount { get; set; }

        public decimal? VatDeductableAmount { get; set; }

        public decimal? PayableAmount { get; set; }
    }
}