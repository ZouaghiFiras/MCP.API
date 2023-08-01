namespace CED.Data.Entities
{
    public class NoteTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? NotId { get; set; }

        public string? NotCode { get; set; }

        public string? NotShortName { get; set; }

        public string? NotLongName { get; set; }

        public bool? NotInactive { get; set; }

        public Guid? NotLocalizableEntryId { get; set; }

        public DateTime? NotCreatedDate { get; set; }

        public string? NotCreatedBy { get; set; }

        public DateTime? NotLastModifiedDate { get; set; }

        public string? NotLastModifiedBy { get; set; }
    }
}