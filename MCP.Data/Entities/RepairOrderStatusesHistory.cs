namespace CED.Data.Entities
{
    public class RepairOrderStatusesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? RosId { get; set; }

        public string? RosCode { get; set; }

        public string? RosShortName { get; set; }

        public string? RosLongName { get; set; }

        public bool? RosInactive { get; set; }

        public DateTime? RosCreatedDate { get; set; }

        public string? RosCreatedBy { get; set; }

        public DateTime? RosLastModifiedDate { get; set; }

        public string? RosLastModifiedBy { get; set; }
    }
}