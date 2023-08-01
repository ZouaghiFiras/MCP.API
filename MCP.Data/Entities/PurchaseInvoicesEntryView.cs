namespace CED.Data.Entities
{
    public class PurchaseInvoicesEntryView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string Number { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TaxExemptedAmount { get; set; }

        public decimal TaxResversedChargeAmount { get; set; }

        public decimal TaxImportAmount { get; set; }

        public string? TaxCountryCode { get; set; }

        public decimal NetAmount { get; set; }

        public decimal? OpenAmount { get; set; }

        public DateTime? DueDate { get; set; }

        public string? CurrencyCode { get; set; }

        public double? ExchangeRate { get; set; }

        public bool IsPrinted { get; set; }

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

        public Guid CreditorId { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public string CreditorName { get; set; } = null!;

        public string? CreditorStreetName { get; set; }

        public string? CreditorHouseNo { get; set; }

        public string? CreditorHouseNoAddition { get; set; }

        public string? CreditorPostalCode { get; set; }

        public string? CreditorCity { get; set; }

        public string? CreditorCountryCode { get; set; }

        public string? CreditorVatNumber { get; set; }

        public string? CreditorChamberOfCommerceNumber { get; set; }

        public string? CreditorIban { get; set; }

        public string? CreditorAccountName { get; set; }

        public string? SupplierNumber { get; set; }

        public string SupplierName { get; set; } = null!;

        public string? SupplierStreetName { get; set; }

        public string? SupplierHouseNo { get; set; }

        public string? SupplierHouseNoAddition { get; set; }

        public string? SupplierPostalCode { get; set; }

        public string? SupplierCity { get; set; }

        public string? SupplierCountryCode { get; set; }

        public string? SupplierVatNumber { get; set; }

        public string? SupplierChamberOfCommerceNumber { get; set; }

        public bool IsIntercompany { get; set; }

        public Guid? PaymentConditionId { get; set; }

        public string? PaymentConditionCode { get; set; }

        public string? PaymentConditionName { get; set; }

        public Guid? PaymentMethodId { get; set; }

        public string? PaymentMethodCode { get; set; }

        public string? PaymentMethodName { get; set; }

        public bool IsCredit { get; set; }

        public string? DebitEntryNumber { get; set; }

        public string? CreditEntryNumber { get; set; }

        public decimal BlockedAmount { get; set; }

        public string? BlockedIban { get; set; }

        public Guid? TenantId { get; set; }

        public string? TenantName { get; set; }

        public string? CultureCode { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? EmployeeName { get; set; }

        public string? JournalId { get; set; }

        public string? JouralName { get; set; }

        public string? JournalEntryNumber { get; set; }

        public string? BookingNumber { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        public Guid? SupplierId { get; set; }

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

        public bool PayorIsDossierParty { get; set; }

        public string? JsonEntryForm { get; set; }

        public string? PurchaseInvoiceStatusCode { get; set; }

        public string? PurchaseInvoiceStatusName { get; set; }

        public Guid? PurchaseBacklogId { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public Guid? WorkingOrderId { get; set; }

        public Guid? PaymentExchangeRateId { get; set; }

        public double? PaymentExchangeRate { get; set; }

        public Guid? ForeignToPaymentExchangeRateId { get; set; }

        public double? ForeignToPaymentExchangeRate { get; set; }

        public string? PaymentCurrencyCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}