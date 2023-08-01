namespace CED.Data.Entities
{
    public class DossierStatusHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DshId { get; set; }

        public Guid? DshDossierId { get; set; }

        public Guid? DshDossierStatusId { get; set; }

        public Guid? DshEmployeeId { get; set; }

        public DateTime? DshStartDate { get; set; }

        public DateTime? DshCreatedDate { get; set; }

        public string? DshCreatedBy { get; set; }

        public DateTime? DshLastModifiedDate { get; set; }

        public string? DshLastModifiedBy { get; set; }

        public string? DshStatusChangeReason { get; set; }
    }
}