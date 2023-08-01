namespace CED.Data.Entities
{
    public class WorkingOrderNotesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WonId { get; set; }

        public Guid? WonWorkingOrderId { get; set; }

        public int? WonLineNumber { get; set; }

        public Guid? WonRoleCodeId { get; set; }

        public Guid? WonNoteTypeId { get; set; }

        public string? WonFreeText { get; set; }

        public string? WonTitle { get; set; }

        public DateTime? WonCreatedDate { get; set; }

        public string? WonCreatedBy { get; set; }

        public DateTime? WonLastModifiedDate { get; set; }

        public string? WonLastModifiedBy { get; set; }
    }
}