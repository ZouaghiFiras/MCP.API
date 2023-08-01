namespace CED.Data.Entities
{
    public class WorkingOrderLineStatusTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public string? WltyId { get; set; }

        public string? WltyName { get; set; }

        public bool? WltyInactive { get; set; }

        public Guid? WltyLocalizableEntryId { get; set; }

        public DateTime? WltyCreatedDate { get; set; }

        public string? WltyCreatedBy { get; set; }

        public DateTime? WltyLastModifiedDate { get; set; }

        public string? WltyLastModifiedBy { get; set; }
    }
}