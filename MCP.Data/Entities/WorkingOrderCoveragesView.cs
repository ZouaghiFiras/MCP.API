namespace CED.Data.Entities
{
    public class WorkingOrderCoveragesView
    {
        public Guid Id { get; set; }

        public Guid WorkingOrderId { get; set; }

        public Guid WorkingOrderLineId { get; set; }

        public Guid WorkingOrderLineCostId { get; set; }

        public string? WorkingOrderLineNumber { get; set; }

        public decimal? WorkingOrderGrossAmount { get; set; }

        public decimal? WorkingOrderNetAmount { get; set; }

        public decimal? WorkingOrderTaxAmount { get; set; }

        public decimal? WorkingOrderLineMaxNetAmount { get; set; }

        public Guid InvolvedCoverageId { get; set; }

        public string? ClaimReserveClassificationId { get; set; }

        public decimal? ClaimReserveAmount { get; set; }

        public Guid? ClientId { get; set; }

        public string? ClientCode { get; set; }

        public string ClientName { get; set; } = null!;

        public string? ClientCurrencyCode { get; set; }

        public Guid? MandateId { get; set; }

        public string? MandateCode { get; set; }

        public string? MandateName { get; set; }

        public Guid? InsurerId { get; set; }

        public string? InsurerCode { get; set; }

        public string InsurerName { get; set; } = null!;

        public Guid? InsurancePolicyId { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public string? InsuranceProductType { get; set; }

        public string? CoverageFreeField1 { get; set; }

        public string? CoverageFreeField2 { get; set; }

        public string? CoverageFreeField3 { get; set; }

        public string? CoverageFreeField4 { get; set; }

        public Guid DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? DossierPartyId { get; set; }

        public string? PolicyHolder { get; set; }

        public double? FixedRate { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? MaxNetAmount { get; set; }

        public decimal? MaxTaxAmount { get; set; }

        public decimal? MaxGrossAmount { get; set; }

        public double? TaxRate { get; set; }

        public bool? IsTaxReversedCharge { get; set; }

        public bool? IsTaxExempted { get; set; }

        public bool? IsTaxImport { get; set; }

        public string? TaxCountryCode { get; set; }

        public double? ExchangeRate { get; set; }

        public DateTime? ExchangeRateAccountingDate { get; set; }

        public bool? Inactive { get; set; }

        public bool IsCostOfSales { get; set; }

        public string? CurrencyCode { get; set; }

        public short Priority { get; set; }

        public Guid? FeeInvoiceRecipientId { get; set; }

        public string? FeeInvoiceRecipientCode { get; set; }

        public string? FeeInvoiceRecipientName { get; set; }

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public string? ChargedExpensesInvoiceRecipientCode { get; set; }

        public string? ChargedExpensesInvoiceRecipientName { get; set; }

        public Guid? ServiceId { get; set; }

        public string? ServiceCode { get; set; }

        public string? ServiceName { get; set; }

        public Guid? ClaimReserveId { get; set; }

        public string? ClaimReserveNumber { get; set; }

        public Guid? OldClaimReserveId { get; set; }

        public bool IsUnknownChargedExpensesInvoiceRecipient { get; set; }

        public bool IsResultingInClaimReserve { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}