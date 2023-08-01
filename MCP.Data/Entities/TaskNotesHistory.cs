namespace CED.Data.Entities
{
    public class TaskNotesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? TasnId { get; set; }

        public Guid? TasnTaskId { get; set; }

        public Guid? TasnEmployeeId { get; set; }

        public string? TasnNotes { get; set; }

        public DateTime? TasnCreatedDate { get; set; }

        public string? TasnCreatedBy { get; set; }

        public DateTime? TasnLastModifiedDate { get; set; }

        public string? TasnLastModifiedBy { get; set; }
    }
}