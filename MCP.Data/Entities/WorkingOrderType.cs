namespace CED.Data.Entities
{
    public class WorkingOrderType
    {
        public Guid WotId { get; set; }

        public byte[] WotTimeStamp { get; set; } = null!;

        public string WotCode { get; set; } = null!;

        public string WotName { get; set; } = null!;

        public DateTime WotCreatedDate { get; set; }

        public string? WotCreatedBy { get; set; }

        public DateTime WotLastModifiedDate { get; set; }

        public string? WotLastModifiedBy { get; set; }

        public virtual ICollection<WorkingOrder> WorkingOrders { get; } = new List<WorkingOrder>();
    }
}