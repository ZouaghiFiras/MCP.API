namespace CED.Data.Entities
{
    public class WorkingOrderStatusHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WshId { get; set; }

        public Guid? WshWorkingOrderId { get; set; }

        public Guid? WshWorkingOrderStatusId { get; set; }

        public Guid? WshEmployeeId { get; set; }

        public DateTime? WshStartDate { get; set; }

        public string? WshStatusChangeReason { get; set; }

        public DateTime? WshCreatedDate { get; set; }

        public string? WshCreatedBy { get; set; }

        public DateTime? WshLastModifiedDate { get; set; }

        public string? WshLastModifiedBy { get; set; }
    }
}