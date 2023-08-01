namespace CED.Data.Entities
{
    public class RepairOrderStatus
    {
        public Guid RosId { get; set; }

        public byte[] RosTimeStamp { get; set; } = null!;

        public string RosCode { get; set; } = null!;

        public string? RosShortName { get; set; }

        public string RosLongName { get; set; } = null!;

        public bool RosInactive { get; set; }

        public DateTime RosCreatedDate { get; set; }

        public string? RosCreatedBy { get; set; }

        public DateTime RosLastModifiedDate { get; set; }

        public string? RosLastModifiedBy { get; set; }

        public virtual ICollection<RepairOrderStatusHistory> RepairOrderStatusHistories { get; } =
            new List<RepairOrderStatusHistory>();
    }
}