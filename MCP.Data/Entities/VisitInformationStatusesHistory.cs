namespace CED.Data.Entities
{
    public class VisitInformationStatusesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? VisId { get; set; }

        public string? VisCode { get; set; }

        public string? VisShortName { get; set; }

        public string? VisLongName { get; set; }

        public bool? VisInactive { get; set; }

        public string? VisVisitInformationStatusTypeId { get; set; }

        public Guid? VisLocalizableEntryId { get; set; }

        public DateTime? VisCreatedDate { get; set; }

        public string? VisCreatedBy { get; set; }

        public DateTime? VisLastModifiedDate { get; set; }

        public string? VisLastModifiedBy { get; set; }
    }
}