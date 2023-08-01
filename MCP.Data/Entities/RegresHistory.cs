namespace CED.Data.Entities
{
    public class RegresHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? RgsId { get; set; }

        public Guid? RgsDossierId { get; set; }

        public Guid? RgsInvolvedCoverageId { get; set; }

        public Guid? RgsInvolvedObjectId { get; set; }

        public int? RgsSequenceNumber { get; set; }

        public int? RgsPercentageRegres { get; set; }

        public bool? RgsIsManual { get; set; }

        public bool? RgsIsClearingHouse { get; set; }

        public bool? RgsIsGuaranteeFund { get; set; }

        public decimal? RgsPaymentValue { get; set; }

        public decimal? RgsRetentionValue { get; set; }

        public decimal? RgsRecoveryValueExpected { get; set; }

        public string? RgsStatus { get; set; }

        public string? RgsRecoveryStatementId { get; set; }

        public string? RgsRecoveryStatementNumber { get; set; }

        public DateTime? RgsCreatedDate { get; set; }

        public string? RgsCreatedBy { get; set; }

        public DateTime? RgsLastModifiedDate { get; set; }

        public string? RgsLastModifiedBy { get; set; }
    }
}