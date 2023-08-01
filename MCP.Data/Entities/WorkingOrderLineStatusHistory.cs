namespace CED.Data.Entities
{
    public class WorkingOrderLineStatusHistory
    {
        public Guid WlshId { get; set; }

        public byte[] WlshTimeStamp { get; set; } = null!;

        public Guid WlshWorkingOrderLineId { get; set; }

        public Guid WlshWorkingOrderLineStatusId { get; set; }

        public Guid WlshEmployeeId { get; set; }

        public DateTime WlshStartDate { get; set; }

        public string? WlshStatusChangeReason { get; set; }

        public DateTime WlshCreatedDate { get; set; }

        public string? WlshCreatedBy { get; set; }

        public DateTime WlshLastModifiedDate { get; set; }

        public string? WlshLastModifiedBy { get; set; }

        public virtual WorkingOrderLine WlshWorkingOrderLine { get; set; } = null!;

        public virtual WorkingOrderLineStatus WlshWorkingOrderLineStatus { get; set; } = null!;

        public virtual ICollection<WorkingOrderLineCurrentStatus> WorkingOrderLineCurrentStatuses { get; } =
            new List<WorkingOrderLineCurrentStatus>();
    }
}