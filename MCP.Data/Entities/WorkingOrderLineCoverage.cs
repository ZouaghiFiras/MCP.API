namespace CED.Data.Entities
{
    public class WorkingOrderLineCoverage
    {
        public Guid WoccId { get; set; }

        public byte[] WoccTimeStamp { get; set; } = null!;

        public Guid WoccWorkingOrderLineId { get; set; }

        public Guid? WoccWorkingOrderLineCostId { get; set; }

        public Guid WoccInvolvedCoverageId { get; set; }

        public short WoccPriority { get; set; }

        public double? WoccFixedRate { get; set; }

        public decimal? WoccTaxBase { get; set; }

        public double? WoccTaxRate { get; set; }

        public string? WoccTaxCode { get; set; }

        public decimal? WoccGrossAmount { get; set; }

        public decimal? WoccTaxAmount { get; set; }

        public decimal? WoccNetAmount { get; set; }

        public bool? WoccIsTaxExempted { get; set; }

        public bool? WoccIsTaxReversedCharge { get; set; }

        public bool? WoccIsTaxImport { get; set; }

        public string? WoccCurrencyCode { get; set; }

        public double? WoccExchangeRate { get; set; }

        public Guid? WoccExchangeRateId { get; set; }

        public string? WoccLeadCurrencyCode { get; set; }

        public decimal? WoccMaxGrossAmount { get; set; }

        public decimal? WoccMaxTaxAmount { get; set; }

        public decimal? WoccMaxNetAmount { get; set; }

        public string? WoccTaxCountryCode { get; set; }

        public bool? WoccInactive { get; set; }

        public DateTime? WoccInactiveDate { get; set; }

        public DateTime WoccCreatedDate { get; set; }

        public string? WoccCreatedBy { get; set; }

        public DateTime WoccLastModifiedDate { get; set; }

        public string? WoccLastModifiedBy { get; set; }

        public string? WoccClaimReserveClassificationId { get; set; }

        public decimal? WoccClaimReserveAmount { get; set; }

        public int? WoccLineNumber { get; set; }

        public Guid? WoccProductId { get; set; }

        public string? WoccExtraProductDescription { get; set; }

        public double? WoccQuantity { get; set; }

        public string? WoccUnitOfMeasureId { get; set; }

        public decimal? WoccItemPrice { get; set; }

        public decimal? WoccDiscount { get; set; }

        public Guid? WoccInvolvedObjectId { get; set; }

        public Guid? WoccWorkingOrderLinePartyId { get; set; }

        public virtual ICollection<ClaimReserveLine> ClaimReserveLines { get; } = new List<ClaimReserveLine>();

        public virtual ICollection<SalesOrderToWorkingOrderLineCoverageMapping>
            SalesOrderToWorkingOrderLineCoverageMappings { get; } =
            new List<SalesOrderToWorkingOrderLineCoverageMapping>();

        public virtual InvolvedCoverage WoccInvolvedCoverage { get; set; } = null!;

        public virtual InvolvedObject? WoccInvolvedObject { get; set; }

        public virtual Product? WoccProduct { get; set; }

        public virtual UnitOfMeasure? WoccUnitOfMeasure { get; set; }

        public virtual WorkingOrderLine WoccWorkingOrderLine { get; set; } = null!;

        public virtual WorkingOrderLineCost? WoccWorkingOrderLineCost { get; set; }

        public virtual WorkingOrderLineParty? WoccWorkingOrderLineParty { get; set; }

        public virtual ICollection<WorkingOrderLineCoverageNote> WorkingOrderLineCoverageNotes { get; } =
            new List<WorkingOrderLineCoverageNote>();
    }
}