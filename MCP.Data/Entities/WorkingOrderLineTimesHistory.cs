namespace CED.Data.Entities
{
    public class WorkingOrderLineTimesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WoltId { get; set; }

        public Guid? WoltWorkingOrderLineId { get; set; }

        public DateTime? WoltDate { get; set; }

        public string? WoltDescription { get; set; }

        public TimeSpan? WoltDuration { get; set; }

        public DateTime? WoltCreatedDate { get; set; }

        public string? WoltCreatedBy { get; set; }

        public DateTime? WoltLastModifiedDate { get; set; }

        public string? WoltLastModifiedBy { get; set; }
    }
}