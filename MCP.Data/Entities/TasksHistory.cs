namespace CED.Data.Entities
{
    public class TasksHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? TaskId { get; set; }

        public string? TaskTaskNumber { get; set; }

        public string? TaskDescription { get; set; }

        public DateTime? TaskStartDate { get; set; }

        public DateTime? TaskDueDate { get; set; }

        public string? TaskAuthorizationGroupRoleId { get; set; }

        public DateTime? TaskCreatedDate { get; set; }

        public string? TaskCreatedBy { get; set; }

        public DateTime? TaskLastModifiedDate { get; set; }

        public string? TaskLastModifiedBy { get; set; }
    }
}