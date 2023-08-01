namespace CED.Data.Entities
{
    public class VisitInformationStatusTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public string? VistId { get; set; }

        public string? VistName { get; set; }

        public bool? VistInactive { get; set; }

        public Guid? VistLocalizableEntryId { get; set; }

        public DateTime? VistCreatedDate { get; set; }

        public string? VistCreatedBy { get; set; }

        public DateTime? VistLastModifiedDate { get; set; }

        public string? VistLastModifiedBy { get; set; }
    }
}