namespace CED.Data.Entities
{
    public class WorkingOrderLineIsExecuteVatDeductableHistory
    {
        public Guid WlvhId { get; set; }

        public byte[] WlvhTimeStamp { get; set; } = null!;

        public Guid WlvhWorkingOrderLineId { get; set; }

        public bool? WlvhIsExecuteVatDeductable { get; set; }

        public Guid WlvhEmployeeId { get; set; }

        public DateTime WlvhStartDate { get; set; }

        public string? WlvhIsVatDeductableChangeReason { get; set; }

        public DateTime WlvhCreatedDate { get; set; }

        public string? WlvhCreatedBy { get; set; }

        public DateTime WlvhLastModifiedDate { get; set; }

        public string? WlvhLastModifiedBy { get; set; }

        public virtual Employee WlvhEmployee { get; set; } = null!;

        public virtual WorkingOrderLine WlvhWorkingOrderLine { get; set; } = null!;
    }
}