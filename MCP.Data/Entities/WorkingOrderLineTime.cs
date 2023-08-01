namespace CED.Data.Entities
{
    public class WorkingOrderLineTime
    {
        public Guid WoltId { get; set; }

        public byte[] WoltTimeStamp { get; set; } = null!;

        public Guid WoltWorkingOrderLineId { get; set; }

        public DateTime WoltDate { get; set; }

        public string? WoltDescription { get; set; }

        public TimeSpan WoltDuration { get; set; }

        public DateTime WoltCreatedDate { get; set; }

        public string? WoltCreatedBy { get; set; }

        public DateTime WoltLastModifiedDate { get; set; }

        public string? WoltLastModifiedBy { get; set; }

        public virtual WorkingOrderLine WoltWorkingOrderLine { get; set; } = null!;
    }
}