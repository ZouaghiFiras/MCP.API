namespace CED.Data.Entities
{
    public class WorkingOrderLineOperationalStatusHistory
    {
        public Guid WolshId { get; set; }

        public byte[] WolshTimeStamp { get; set; } = null!;

        public Guid WolshWorkingOrderLineId { get; set; }

        public Guid WolshWorkingOrderLineOperationalStatusId { get; set; }

        public Guid WolshEmployeeId { get; set; }

        public DateTime WolshStartDate { get; set; }

        public string? WolshStatusChangeReason { get; set; }

        public DateTime WolshCreatedDate { get; set; }

        public string? WolshCreatedBy { get; set; }

        public DateTime WolshLastModifiedDate { get; set; }

        public string? WolshLastModifiedBy { get; set; }

        public virtual WorkingOrderLine WolshWorkingOrderLine { get; set; } = null!;

        public virtual WorkingOrderLineOperationalStatus WolshWorkingOrderLineOperationalStatus { get; set; } = null!;
    }
}