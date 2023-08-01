namespace CED.Data.Entities
{
    public class WorkingOrderLineLogHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WolhId { get; set; }

        public Guid? WolhWorkingOrderLineId { get; set; }

        public int? WolhLineNumber { get; set; }

        public Guid? WolhRoleCodeId { get; set; }

        public Guid? WolhLogHistoryTypeId { get; set; }

        public string? WolhFreeText { get; set; }

        public DateTime? WolhCreatedDate { get; set; }

        public string? WolhCreatedBy { get; set; }

        public DateTime? WolhLastModifiedDate { get; set; }

        public string? WolhLastModifiedBy { get; set; }
    }
}