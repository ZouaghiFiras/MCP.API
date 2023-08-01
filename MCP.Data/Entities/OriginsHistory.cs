namespace CED.Data.Entities
{
    public class OriginsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? OrId { get; set; }

        public string? OrCode { get; set; }

        public string? OrShortName { get; set; }

        public string? OrLongName { get; set; }

        public bool? OrInactive { get; set; }

        public DateTime? OrCreatedDate { get; set; }

        public string? OrCreatedBy { get; set; }

        public DateTime? OrLastModifiedDate { get; set; }

        public string? OrLastModifiedBy { get; set; }
    }
}