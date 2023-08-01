namespace CED.Data.Entities
{
    public class DossierLinesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DolId { get; set; }

        public Guid? DolDossierId { get; set; }

        public short? DolNumber { get; set; }

        public string? DolDescription { get; set; }

        public Guid? DolReparActionTypeId { get; set; }

        public Guid? DolStatus { get; set; }

        public bool? DolCanceled { get; set; }

        public string? DolPriority { get; set; }

        public DateTime? DolCreatedDate { get; set; }

        public string? DolCreatedBy { get; set; }

        public DateTime? DolLastModifiedDate { get; set; }

        public string? DolLastModifiedBy { get; set; }

        public Guid? DolSkillId { get; set; }
    }
}