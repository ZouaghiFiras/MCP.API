namespace CED.Data.Entities
{
    public class WorkingOrderStatusHistory
    {
        public Guid WshId { get; set; }

        public byte[] WshTimeStamp { get; set; } = null!;

        public Guid WshWorkingOrderId { get; set; }

        public Guid WshWorkingOrderStatusId { get; set; }

        public Guid WshEmployeeId { get; set; }

        public DateTime WshStartDate { get; set; }

        public string? WshStatusChangeReason { get; set; }

        public DateTime WshCreatedDate { get; set; }

        public string? WshCreatedBy { get; set; }

        public DateTime WshLastModifiedDate { get; set; }

        public string? WshLastModifiedBy { get; set; }

        public virtual ICollection<WorkingOrderCurrentStatus> WorkingOrderCurrentStatuses { get; } =
            new List<WorkingOrderCurrentStatus>();

        public virtual WorkingOrder WshWorkingOrder { get; set; } = null!;

        public virtual WorkingOrderStatus WshWorkingOrderStatus { get; set; } = null!;
    }
}