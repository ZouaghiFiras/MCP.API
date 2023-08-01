namespace CED.Data.Entities
{
    public class DossierLogHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DhlId { get; set; }

        public Guid? DhlDossierId { get; set; }

        public int? DhlLineNumber { get; set; }

        public Guid? DhlRoleCodeId { get; set; }

        public Guid? DhlLogHistoryTypeId { get; set; }

        public string? DhlFreeText { get; set; }

        public DateTime? DhlCreatedDate { get; set; }

        public string? DhlCreatedBy { get; set; }

        public DateTime? DhlLastModifiedDate { get; set; }

        public string? DhlLastModifiedBy { get; set; }
    }
}