namespace CED.Data.Entities
{
    public class InvolvedComponentsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? IcoId { get; set; }

        public Guid? IcoInvolvedObjectId { get; set; }

        public DateTime? IcoCreatedDate { get; set; }

        public string? IcoCreatedBy { get; set; }

        public DateTime? IcoLastModifiedDate { get; set; }

        public string? IcoLastModifiedBy { get; set; }
    }
}