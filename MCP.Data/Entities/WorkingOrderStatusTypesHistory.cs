namespace CED.Data.Entities
{
    public class WorkingOrderStatusTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public string? WtyId { get; set; }

        public string? WtyName { get; set; }

        public bool? WtyInactive { get; set; }

        public Guid? WtyLocalizableEntryId { get; set; }

        public DateTime? WtyCreatedDate { get; set; }

        public string? WtyCreatedBy { get; set; }

        public DateTime? WtyLastModifiedDate { get; set; }

        public string? WtyLastModifiedBy { get; set; }
    }
}