namespace CED.Data.Entities
{
    public class TaskCompletionsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? TascId { get; set; }

        public Guid? TascTaskId { get; set; }

        public Guid? TascEmployeeId { get; set; }

        public DateTime? TascCompletionDate { get; set; }

        public bool? TascIsCanceled { get; set; }

        public DateTime? TascCreatedDate { get; set; }

        public string? TascCreatedBy { get; set; }

        public DateTime? TascLastModifiedDate { get; set; }

        public string? TascLastModifiedBy { get; set; }
    }
}