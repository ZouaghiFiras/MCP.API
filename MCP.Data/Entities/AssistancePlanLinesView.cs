namespace CED.Data.Entities
{
    public class AssistancePlanLinesView
    {
        public Guid Id { get; set; }

        public Guid AssistancePlanId { get; set; }

        public int LineNumber { get; set; }

        public Guid ServiceId { get; set; }

        public string ServiceCode { get; set; } = null!;

        public string ServiceName { get; set; } = null!;

        public Guid? SubServiceGroupId { get; set; }

        public Guid? MainServiceGroupId { get; set; }

        public double? Quantity { get; set; }

        public string? UnitOfMeasureId { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Discount { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxBase { get; set; }

        public double? TaxRate { get; set; }

        public string? TaxCode { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public bool IsTaxBeforeDiscount { get; set; }

        public bool TaxExempted { get; set; }

        public bool TaxReversedCharge { get; set; }

        public bool TaxImport { get; set; }

        public string? TaxCountryCode { get; set; }

        public bool IsCostOfSales { get; set; }

        public bool? Inactive { get; set; }

        public string? CostOfSalesComments { get; set; }

        public string? Notes { get; set; }

        public bool? CostRateAgreementApplicable { get; set; }

        public double? ExchangeRate { get; set; }

        public Guid? ExchangeRateId { get; set; }

        public Guid SupplierId { get; set; }

        public string SupplierName { get; set; } = null!;

        public string? SupplierExternalCode { get; set; }

        public string? LeadCurrencyCode { get; set; }

        public string? ForeignCurrencyCode { get; set; }

        public decimal? MaxNetAmount { get; set; }

        public decimal? MaxTaxAmount { get; set; }

        public decimal? MaxGrossAmount { get; set; }

        public Guid DossierId { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}