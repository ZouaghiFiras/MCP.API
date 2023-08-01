namespace CED.Data.Entities
{
    public class WorkingOrderLineCoveragesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid WoccId { get; set; }

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

        public string? WoccClaimReserveClassificationId { get; set; }

        public decimal? WoccClaimReserveAmount { get; set; }

        public int? WoccLineNumber { get; set; }

        public Guid? WoccProductId { get; set; }

        public double? WoccQuantity { get; set; }

        public decimal? WoccItemPrice { get; set; }

        public decimal? WoccDiscount { get; set; }

        public Guid? WoccInvolvedObjectId { get; set; }

        public string? WoccExtraProductDescription { get; set; }

        public string? WoccUnitOfMeasureId { get; set; }

        public DateTime WoccCreatedDate { get; set; }

        public string? WoccCreatedBy { get; set; }

        public DateTime WoccLastModifiedDate { get; set; }

        public string? WoccLastModifiedBy { get; set; }
    }
}