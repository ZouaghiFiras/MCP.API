namespace CED.Data.Entities
{
    public class DossierAssignmentNotesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DanId { get; set; }

        public Guid? DanDossierAssignmentId { get; set; }

        public int? DanLineNumber { get; set; }

        public Guid? DanRoleCodeId { get; set; }

        public Guid? DanNoteTypeId { get; set; }

        public string? DanFreeText { get; set; }

        public string? DanTitle { get; set; }

        public DateTime? DanCreatedDate { get; set; }

        public string? DanCreatedBy { get; set; }

        public DateTime? DanLastModifiedDate { get; set; }

        public string? DanLastModifiedBy { get; set; }
    }
}