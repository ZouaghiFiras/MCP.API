namespace CED.Data.Entities
{
    public class AssistancePlanStatusesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? ApsId { get; set; }

        public string? ApsCode { get; set; }

        public string? ApsShortName { get; set; }

        public string? ApsLongName { get; set; }

        public bool? ApsInactive { get; set; }

        public Guid? ApsLocalizableEntryId { get; set; }

        public DateTime? ApsCreatedDate { get; set; }

        public string? ApsCreatedBy { get; set; }

        public DateTime? ApsLastModifiedDate { get; set; }

        public string? ApsLastModifiedBy { get; set; }
    }
}