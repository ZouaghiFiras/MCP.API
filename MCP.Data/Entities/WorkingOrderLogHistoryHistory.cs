namespace CED.Data.Entities
{
    public class WorkingOrderLogHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WolId { get; set; }

        public Guid? WolWorkingOrderId { get; set; }

        public int? WolLineNumber { get; set; }

        public Guid? WolRoleCodeId { get; set; }

        public Guid? WolLogHistoryTypeId { get; set; }

        public string? WolFreeText { get; set; }

        public DateTime? WolCreatedDate { get; set; }

        public string? WolCreatedBy { get; set; }

        public DateTime? WolLastModifiedDate { get; set; }

        public string? WolLastModifiedBy { get; set; }
    }
}