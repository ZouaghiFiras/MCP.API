namespace CED.Data.Entities
{
    public class LiabilityStatusesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? LstId { get; set; }

        public string? LstCode { get; set; }

        public string? LstShortName { get; set; }

        public string? LstLongName { get; set; }

        public bool? LstInactive { get; set; }

        public Guid? LstLocalizableEntryId { get; set; }

        public DateTime? LstCreatedDate { get; set; }

        public string? LstCreatedBy { get; set; }

        public DateTime? LstLastModifiedDate { get; set; }

        public string? LstLastModifiedBy { get; set; }
    }
}