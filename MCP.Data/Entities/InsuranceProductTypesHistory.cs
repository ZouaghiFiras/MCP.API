namespace CED.Data.Entities
{
    public class InsuranceProductTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? IptId { get; set; }

        public string? IptCode { get; set; }

        public string? IptShortName { get; set; }

        public string? IptLongName { get; set; }

        public bool? IptInactive { get; set; }

        public Guid? IptLocalizableEntryId { get; set; }

        public DateTime? IptCreatedDate { get; set; }

        public string? IptCreatedBy { get; set; }

        public DateTime? IptLastModifiedDate { get; set; }

        public string? IptLastModifiedBy { get; set; }
    }
}