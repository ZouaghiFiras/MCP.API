namespace CED.Data.Entities
{
    public class WorkingOrderLineStatusHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WlshId { get; set; }

        public Guid? WlshWorkingOrderLineId { get; set; }

        public Guid? WlshWorkingOrderLineStatusId { get; set; }

        public Guid? WlshEmployeeId { get; set; }

        public DateTime? WlshStartDate { get; set; }

        public string? WlshStatusChangeReason { get; set; }

        public DateTime? WlshCreatedDate { get; set; }

        public string? WlshCreatedBy { get; set; }

        public DateTime? WlshLastModifiedDate { get; set; }

        public string? WlshLastModifiedBy { get; set; }
    }
}