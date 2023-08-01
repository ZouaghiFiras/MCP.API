namespace CED.Data.Entities
{
    public class WorkingOrderStatusType
    {
        public string WtyId { get; set; } = null!;

        public byte[] WtyTimeStamp { get; set; } = null!;

        public string WtyName { get; set; } = null!;

        public bool WtyInactive { get; set; }

        public Guid? WtyLocalizableEntryId { get; set; }

        public DateTime WtyCreatedDate { get; set; }

        public string? WtyCreatedBy { get; set; }

        public DateTime WtyLastModifiedDate { get; set; }

        public string? WtyLastModifiedBy { get; set; }

        public virtual ICollection<WorkingOrderCurrentStatus> WorkingOrderCurrentStatuses { get; } =
            new List<WorkingOrderCurrentStatus>();

        public virtual ICollection<WorkingOrderStatus> WorkingOrderStatuses { get; } = new List<WorkingOrderStatus>();

        public virtual LocalizableEntry? WtyLocalizableEntry { get; set; }
    }
}