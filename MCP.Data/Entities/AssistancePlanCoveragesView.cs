namespace CED.Data.Entities
{
    public class AssistancePlanCoveragesView
    {
        public Guid Id { get; set; }

        public Guid AssistancePlanId { get; set; }

        public Guid AssistancePlanLineId { get; set; }

        public int AssistancePlanLineNumber { get; set; }

        public decimal? AssistancePlanGrossAmount { get; set; }

        public decimal? AssistancePlanNetAmount { get; set; }

        public decimal? AssistancePlanTaxAmount { get; set; }

        public decimal? AssistancePlanLineMaxNetAmount { get; set; }

        public Guid AssistancePlanTypeId { get; set; }

        public string AssistancePlanTypeName { get; set; } = null!;

        public Guid? ClaimReserveTypeId { get; set; }

        public string? ClaimReserveTypeName { get; set; }

        public Guid InvolvedCoverageId { get; set; }

        public string? ClaimReserveClassificationId { get; set; }

        public Guid? ClientId { get; set; }

        public string? ClientCode { get; set; }

        public string ClientName { get; set; } = null!;

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

        public string? PolicyHolder { get; set; }

        public double? FixedRate { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public double? TaxRate { get; set; }

        public bool? TaxReversedCharge { get; set; }

        public bool? TaxExempted { get; set; }

        public bool? TaxImport { get; set; }

        public string? TaxCountryCode { get; set; }

        public double? ExchangeRate { get; set; }

        public DateTime? ExchangeRateAccountingDate { get; set; }

        public decimal? NetAmount { get; set; }

        public string? Notes { get; set; }

        public bool? Inactive { get; set; }

        public bool? IsCostOfSales { get; set; }

        public bool? AssistancePlanLineInactive { get; set; }

        public string? CurrencyCode { get; set; }

        public decimal? MaxNetAmount { get; set; }

        public decimal? MaxTaxAmount { get; set; }

        public decimal? MaxGrossAmount { get; set; }

        public short? Priority { get; set; }

        public Guid? FeeInvoiceRecipientId { get; set; }

        public string? FeeInvoiceRecipientCode { get; set; }

        public string? FeeInvoiceRecipientName { get; set; }

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public string? ChargedExpensesInvoiceRecipientCode { get; set; }

        public string? ChargedExpensesInvoiceRecipientName { get; set; }

        public Guid ServiceId { get; set; }

        public string? ServiceCode { get; set; }

        public string? ServiceName { get; set; }

        public Guid? ClaimReserveId { get; set; }

        public string? ClaimReserveNumber { get; set; }

        public Guid? OldClaimReserveId { get; set; }

        public bool IsUnknownChargedExpensesInvoiceRecipient { get; set; }

        public Guid? InvolvedObjectId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}