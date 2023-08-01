namespace CED.Data.Entities
{
    public class RepairOrderStatusHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? RohId { get; set; }

        public Guid? RohRepairOrderId { get; set; }

        public Guid? RohRepairOrderStatusId { get; set; }

        public DateTime? RohStartDate { get; set; }

        public DateTime? RohCreatedDate { get; set; }

        public string? RohCreatedBy { get; set; }

        public DateTime? RohLastModifiedDate { get; set; }

        public string? RohLastModifiedBy { get; set; }
    }
}