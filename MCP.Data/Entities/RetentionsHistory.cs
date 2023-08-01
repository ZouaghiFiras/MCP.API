namespace CED.Data.Entities
{
    public class RetentionsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? RtnId { get; set; }

        public Guid? RtnClaimId { get; set; }

        public Guid? RtnCostTypeId { get; set; }

        public int? RtnSequenceNumber { get; set; }

        public decimal? RtnRetentionAmount { get; set; }

        public DateTime? RtnCreatedDate { get; set; }

        public string? RtnCreatedBy { get; set; }

        public DateTime? RtnLastModifiedDate { get; set; }

        public string? RtnLastModifiedBy { get; set; }
    }
}