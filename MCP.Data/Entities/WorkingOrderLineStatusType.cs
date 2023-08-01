namespace CED.Data.Entities
{
    public class WorkingOrderLineStatusType
    {
        public string WltyId { get; set; } = null!;

        public byte[] WltyTimeStamp { get; set; } = null!;

        public string WltyName { get; set; } = null!;

        public bool WltyInactive { get; set; }

        public Guid? WltyLocalizableEntryId { get; set; }

        public DateTime WltyCreatedDate { get; set; }

        public string? WltyCreatedBy { get; set; }

        public DateTime WltyLastModifiedDate { get; set; }

        public string? WltyLastModifiedBy { get; set; }

        public virtual LocalizableEntry? WltyLocalizableEntry { get; set; }

        public virtual ICollection<WorkingOrderLineCurrentStatus> WorkingOrderLineCurrentStatuses { get; } =
            new List<WorkingOrderLineCurrentStatus>();

        public virtual ICollection<WorkingOrderLineStatus> WorkingOrderLineStatuses { get; } =
            new List<WorkingOrderLineStatus>();
    }
}