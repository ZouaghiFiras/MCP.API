namespace CED.Data.Entities
{
    public class LocationTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? LctId { get; set; }

        public string? LctCode { get; set; }

        public string? LctShortName { get; set; }

        public string? LctLongName { get; set; }

        public bool? LctInactive { get; set; }

        public Guid? LctLocalizableEntryId { get; set; }

        public DateTime? LctCreatedDate { get; set; }

        public string? LctCreatedBy { get; set; }

        public DateTime? LctLastModifiedDate { get; set; }

        public string? LctLastModifiedBy { get; set; }
    }
}