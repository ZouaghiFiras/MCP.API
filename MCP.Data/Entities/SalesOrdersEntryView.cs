namespace CED.Data.Entities
{
    public class SalesOrdersEntryView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string Number { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryBatch { get; set; }

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

        public decimal? Discount { get; set; }

        public DateTime? DueDate { get; set; }

        public string? CurrencyCode { get; set; }

        public double? ExchangeRate { get; set; }

        public DateTime? ExchangeRateAccountingDate { get; set; }

        public Guid? ExchangeRateProviderId { get; set; }

        public string? ExchangeRateProviderCode { get; set; }

        public string? ExchangeRateProviderName { get; set; }

        public bool IsPrinted { get; set; }

        public bool IsImported { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public Guid? SalesOrderTypeId { get; set; }

        public string? SalesOrderTypeCode { get; set; }

        public string? SalesOrderTypeName { get; set; }

        public Guid ClientId { get; set; }

        public string ClientNumber { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public string? ClientPhone { get; set; }

        public string? ClientEmail { get; set; }

        public string? ClientWebsite { get; set; }

        public string? ClientVatNumber { get; set; }

        public string? ClientChamberOfCommerceNumber { get; set; }

        public string? ClientStreetName { get; set; }

        public string? ClientHouseNo { get; set; }

        public string? ClientHouseNoAddition { get; set; }

        public string? ClientPostalCode { get; set; }

        public string? ClientCity { get; set; }

        public string? ClientProvince { get; set; }

        public string? ClientCountryCode { get; set; }

        public bool IsIntercompany { get; set; }

        public bool IsVoided { get; set; }

        public Guid? PaymentConditionId { get; set; }

        public string? PaymentConditionCode { get; set; }

        public string? PaymentConditionName { get; set; }

        public string? PaymentReference { get; set; }

        public string? LeadCurrencyCode { get; set; }

        public bool IsCredit { get; set; }

        public string? DebitEntryNumber { get; set; }

        public Guid? DebitSalesOrderId { get; set; }

        public Guid? TenantId { get; set; }

        public string? TenantName { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public Guid? DossierPartyId { get; set; }

        public string? DossierPartyName { get; set; }

        public string? SalesOrderStatusCode { get; set; }

        public string SalesOrderStatusName { get; set; } = null!;

        public Guid? DebtorId { get; set; }

        public string? DebtorNumber { get; set; }

        public string? DebtorName { get; set; }

        public string? DebtorStreetName { get; set; }

        public string? DebtorHouseNo { get; set; }

        public string? DebtorHouseNoAddition { get; set; }

        public string? DebtorPostalCode { get; set; }

        public string? DebtorCity { get; set; }

        public string? DebtorCountryCode { get; set; }

        public string? DebtorVatNumber { get; set; }

        public string? DebtorIban { get; set; }

        public string? DebtorChamberOfCommerceNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}