namespace CED.Data.Entities
{
    public class TaskMembersHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? TasmId { get; set; }

        public Guid? TasmTaskId { get; set; }

        public Guid? TasmEmployeeId { get; set; }

        public DateTime? TasmCreatedDate { get; set; }

        public string? TasmCreatedBy { get; set; }

        public DateTime? TasmLastModifiedDate { get; set; }

        public string? TasmLastModifiedBy { get; set; }
    }
}