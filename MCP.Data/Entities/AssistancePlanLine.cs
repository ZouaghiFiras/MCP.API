namespace CED.Data.Entities
{
    public class AssistancePlanLine
    {
        public Guid AplId { get; set; }

        public byte[] AplTimeStamp { get; set; } = null!;

        public Guid AplAssistancePlanId { get; set; }

        public int AplLineNumber { get; set; }

        public Guid AplServiceId { get; set; }

        public double? AplQuantity { get; set; }

        public string? AplUnitOfMeasureId { get; set; }

        public decimal? AplUnitPrice { get; set; }

        public decimal? AplDiscount { get; set; }

        public decimal? AplGrossAmount { get; set; }

        public decimal? AplTaxBase { get; set; }

        public double? AplTaxRate { get; set; }

        public string? AplTaxCode { get; set; }

        public decimal? AplTaxAmount { get; set; }

        public decimal? AplNetAmount { get; set; }

        public bool AplIsTaxBeforeDiscount { get; set; }

        public bool AplTaxExempted { get; set; }

        public bool AplTaxReversedCharge { get; set; }

        public bool AplTaxImport { get; set; }

        public bool AplIsCostOfSales { get; set; }

        public string? AplCostOfSalesComments { get; set; }

        public bool? AplCostRateAgreementApplicable { get; set; }

        public bool? AplInactive { get; set; }

        public string? AplNotes { get; set; }

        public double? AplExchangeRate { get; set; }

        public Guid? AplExchangeRateId { get; set; }

        public decimal? AplMaxGrossAmount { get; set; }

        public decimal? AplMaxTaxAmount { get; set; }

        public decimal? AplMaxNetAmount { get; set; }

        public string? AplTaxCountryCode { get; set; }

        public DateTime AplCreatedDate { get; set; }

        public string? AplCreatedBy { get; set; }

        public DateTime AplLastModifiedDate { get; set; }

        public string? AplLastModifiedBy { get; set; }

        public virtual AssistancePlan AplAssistancePlan { get; set; } = null!;

        public virtual ExchangeRate? AplExchangeRateNavigation { get; set; }

        public virtual Service AplService { get; set; } = null!;

        public virtual UnitOfMeasure? AplUnitOfMeasure { get; set; }

        public virtual ICollection<AssistancePlanCoverage> AssistancePlanCoverages { get; } =
            new List<AssistancePlanCoverage>();

        public virtual ICollection<ClaimReserveAssistancePlan> ClaimReserveAssistancePlans { get; } =
            new List<ClaimReserveAssistancePlan>();

        public virtual ICollection<ClaimReserveLine> ClaimReserveLines { get; } = new List<ClaimReserveLine>();

        public virtual ICollection<PurchaseInvoiceAssistancePlan> PurchaseInvoiceAssistancePlans { get; } =
            new List<PurchaseInvoiceAssistancePlan>();
    }
}