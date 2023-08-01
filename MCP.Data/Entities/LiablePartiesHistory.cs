namespace CED.Data.Entities
{
    public class LiablePartiesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? LipId { get; set; }

        public string? LipCode { get; set; }

        public string? LipShortName { get; set; }

        public string? LipLongName { get; set; }

        public bool? LipInactive { get; set; }

        public DateTime? LipCreatedDate { get; set; }

        public string? LipCreatedBy { get; set; }

        public DateTime? LipLastModifiedDate { get; set; }

        public string? LipLastModifiedBy { get; set; }
    }
}