namespace CED.Data.Entities
{
    public class AssistancePlanCoveragesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? ApcId { get; set; }

        public Guid? ApcAssistancePlanLineId { get; set; }

        public Guid? ApcInvolvedCoverageId { get; set; }

        public double? ApcFixedRate { get; set; }

        public decimal? ApcTaxBase { get; set; }

        public double? ApcTaxRate { get; set; }

        public string? ApcTaxCode { get; set; }

        public decimal? ApcGrossAmount { get; set; }

        public decimal? ApcTaxAmount { get; set; }

        public decimal? ApcNetAmount { get; set; }

        public bool? ApcTaxExempted { get; set; }

        public bool? ApcTaxReversedCharge { get; set; }

        public bool? ApcTaxImport { get; set; }

        public string? ApcCurrencyCode { get; set; }

        public string? ApcNotes { get; set; }

        public DateTime? ApcCreatedDate { get; set; }

        public string? ApcCreatedBy { get; set; }

        public DateTime? ApcLastModifiedDate { get; set; }

        public string? ApcLastModifiedBy { get; set; }

        public double? ApcExchangeRate { get; set; }

        public bool? ApcInactive { get; set; }

        public Guid? ApcExchangeRateId { get; set; }

        public string? ApcLeadCurrencyCode { get; set; }

        public short? ApcPriority { get; set; }

        public decimal? ApcMaxGrossAmount { get; set; }

        public decimal? ApcMaxTaxAmount { get; set; }

        public decimal? ApcMaxNetAmount { get; set; }

        public string? ApcTaxCountryCode { get; set; }
    }
}