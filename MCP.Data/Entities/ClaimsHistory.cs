namespace CED.Data.Entities
{
    public class ClaimsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? ClmId { get; set; }

        public Guid? ClmPaymentId { get; set; }

        public Guid? ClmCostTypeId { get; set; }

        public decimal? ClmClaimAmount { get; set; }

        public DateTime? ClmCreatedDate { get; set; }

        public string? ClmCreatedBy { get; set; }

        public DateTime? ClmLastModifiedDate { get; set; }

        public string? ClmLastModifiedBy { get; set; }
    }
}