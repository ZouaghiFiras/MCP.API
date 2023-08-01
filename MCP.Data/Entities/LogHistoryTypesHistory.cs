namespace CED.Data.Entities
{
    public class LogHistoryTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? LhtId { get; set; }

        public string? LhtCode { get; set; }

        public string? LhtShortName { get; set; }

        public string? LhtLongName { get; set; }

        public bool? LhtInactive { get; set; }

        public Guid? LhtLocalizableEntryId { get; set; }

        public DateTime? LhtCreatedDate { get; set; }

        public string? LhtCreatedBy { get; set; }

        public DateTime? LhtLastModifiedDate { get; set; }

        public string? LhtLastModifiedBy { get; set; }
    }
}