namespace CED.Data.Entities
{
    public class WorkingOrdersHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WoId { get; set; }

        public Guid? WoEmployeeId { get; set; }

        public Guid? WoDossierId { get; set; }

        public Guid? WoDossierAssignmentId { get; set; }

        public DateTime? WoCreatedDate { get; set; }

        public string? WoCreatedBy { get; set; }

        public DateTime? WoLastModifiedDate { get; set; }

        public string? WoLastModifiedBy { get; set; }

        public string? WoWorkingOrderNumber { get; set; }
    }
}