namespace CED.Data.Entities
{
    public class RepairOrderStatusHistory
    {
        public Guid RohId { get; set; }

        public byte[] RohTimeStamp { get; set; } = null!;

        public Guid RohRepairOrderId { get; set; }

        public Guid RohRepairOrderStatusId { get; set; }

        public DateTime RohStartDate { get; set; }

        public DateTime RohCreatedDate { get; set; }

        public string? RohCreatedBy { get; set; }

        public DateTime RohLastModifiedDate { get; set; }

        public string? RohLastModifiedBy { get; set; }

        public virtual RepairOrder RohRepairOrder { get; set; } = null!;

        public virtual RepairOrderStatus RohRepairOrderStatus { get; set; } = null!;
    }
}