namespace CED.Data.Entities
{
    public class DossierAssignmentStatusHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? AshId { get; set; }

        public Guid? AshDossierAssignmentId { get; set; }

        public Guid? AshDossierAssignmentStatusId { get; set; }

        public Guid? AshEmployeeId { get; set; }

        public DateTime? AshStartDate { get; set; }

        public DateTime? AshCreatedDate { get; set; }

        public string? AshCreatedBy { get; set; }

        public DateTime? AshLastModifiedDate { get; set; }

        public string? AshLastModifiedBy { get; set; }

        public string? AshReason { get; set; }
    }
}