namespace CED.Data.Entities
{
    public class WorkingOrderLineIsOwnRiskHistory
    {
        public Guid WlohId { get; set; }

        public byte[] WlohTimeStamp { get; set; } = null!;

        public Guid WlohWorkingOrderLineId { get; set; }

        public bool? WlohIsOwnRisk { get; set; }

        public Guid WlohEmployeeId { get; set; }

        public DateTime WlohStartDate { get; set; }

        public string? WlohIsOwnRiskChangeReason { get; set; }

        public DateTime WlohCreatedDate { get; set; }

        public string? WlohCreatedBy { get; set; }

        public DateTime WlohLastModifiedDate { get; set; }

        public string? WlohLastModifiedBy { get; set; }

        public virtual Employee WlohEmployee { get; set; } = null!;

        public virtual WorkingOrderLine WlohWorkingOrderLine { get; set; } = null!;
    }
}