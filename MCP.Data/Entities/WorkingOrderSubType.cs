namespace CED.Data.Entities
{
    public class WorkingOrderSubType
    {
        public Guid WostId { get; set; }

        public byte[] WostTimeStamp { get; set; } = null!;

        public string WostCode { get; set; } = null!;

        public string WostName { get; set; } = null!;

        public DateTime WostCreatedDate { get; set; }

        public string? WostCreatedBy { get; set; }

        public DateTime WostLastModifiedDate { get; set; }

        public string? WostLastModifiedBy { get; set; }

        public virtual ICollection<WorkingOrder> WorkingOrders { get; } = new List<WorkingOrder>();
    }
}