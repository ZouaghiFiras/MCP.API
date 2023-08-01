namespace CED.Data.Entities
{
    public class WorkingOrderLineCost
    {
        public Guid WolcId { get; set; }

        public byte[] WolcTimeStamp { get; set; } = null!;

        public Guid WolcWorkingOrderLineId { get; set; }

        public string? WolcDescription { get; set; }

        public decimal WolcAmount { get; set; }

        public Guid WolcWorkingOrderLineCostTypeId { get; set; }

        public Guid? WolcCostTypeId { get; set; }

        public bool? WolcVat { get; set; }

        public int? WolcLineNumber { get; set; }

        public Guid? WolcServiceId { get; set; }

        public double? WolcQuantity { get; set; }

        public string? WolcUnitOfMeasureId { get; set; }

        public decimal? WolcUnitPrice { get; set; }

        public decimal? WolcDiscount { get; set; }

        public decimal? WolcGrossAmount { get; set; }

        public decimal? WolcTaxBase { get; set; }

        public double? WolcTaxRate { get; set; }

        public string? WolcTaxCode { get; set; }

        public decimal? WolcTaxAmount { get; set; }

        public decimal? WolcNetAmount { get; set; }

        public bool WolcIsTaxBeforeDiscount { get; set; }

        public bool WolcIsTaxExempted { get; set; }

        public bool WolcIsTaxReversedCharge { get; set; }

        public bool WolcIsTaxImport { get; set; }

        public bool WolcIsCostOfSales { get; set; }

        public decimal? WolcCostOfSalesAmount { get; set; }

        public string? WolcCostOfSalesComments { get; set; }

        public double? WolcExchangeRate { get; set; }

        public Guid? WolcExchangeRateId { get; set; }

        public decimal? WolcMaxGrossAmount { get; set; }

        public decimal? WolcMaxTaxAmount { get; set; }

        public decimal? WolcMaxNetAmount { get; set; }

        public string? WolcTaxCountryCode { get; set; }

        public bool? WolcCostRateAgreementApplicable { get; set; }

        public bool? WolcInactive { get; set; }

        public DateTime? WolcInactiveDate { get; set; }

        public DateTime WolcCreatedDate { get; set; }

        public string? WolcCreatedBy { get; set; }

        public DateTime WolcLastModifiedDate { get; set; }

        public string? WolcLastModifiedBy { get; set; }

        public Guid? WolcDossierPartyId { get; set; }

        public string? WolcClaimReserveClassificationId { get; set; }

        public decimal? WolcClaimReserveAmount { get; set; }

        public decimal? WolcMaxTaxBaseAmount { get; set; }

        public decimal? WolcMaxTaxExemptedAmount { get; set; }

        public decimal? WolcMaxTaxReversedChargeAmount { get; set; }

        public decimal? WolcMaxTaxImportAmount { get; set; }

        public Guid? WolcInvolvedObjectId { get; set; }

        public decimal? WolcChargeableAmount { get; set; }

        public decimal? WolcMaxChargeableAmount { get; set; }

        public decimal? WolcMaxCostOfSalesAmount { get; set; }

        public Guid? WolcWorkingOrderLinePartyId { get; set; }

        public Guid? WolcWorkingOrderLineInvolvedObjectId { get; set; }

        public virtual ICollection<ClaimReserveLine> ClaimReserveLines { get; } = new List<ClaimReserveLine>();

        public virtual ICollection<ClaimReserveWorkingOrder> ClaimReserveWorkingOrders { get; } =
            new List<ClaimReserveWorkingOrder>();

        public virtual ICollection<PurchaseBacklogWorkingOrderLineCost> PurchaseBacklogWorkingOrderLineCosts { get; } =
            new List<PurchaseBacklogWorkingOrderLineCost>();

        public virtual ICollection<PurchaseInvoiceWorkingOrder> PurchaseInvoiceWorkingOrders { get; } =
            new List<PurchaseInvoiceWorkingOrder>();

        public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

        public virtual DossierCostType? WolcCostType { get; set; }

        public virtual DossierParty? WolcDossierParty { get; set; }

        public virtual InvolvedObject? WolcInvolvedObject { get; set; }

        public virtual WorkingOrderLine WolcWorkingOrderLine { get; set; } = null!;

        public virtual WorkingOrderLineCostType WolcWorkingOrderLineCostType { get; set; } = null!;

        public virtual WorkingOrderLineInvolvedObject? WolcWorkingOrderLineInvolvedObject { get; set; }

        public virtual WorkingOrderLineParty? WolcWorkingOrderLineParty { get; set; }

        public virtual ICollection<WorkingOrderLineCostNote> WorkingOrderLineCostNotes { get; } =
            new List<WorkingOrderLineCostNote>();

        public virtual ICollection<WorkingOrderLineCoverage> WorkingOrderLineCoverages { get; } =
            new List<WorkingOrderLineCoverage>();
    }
}