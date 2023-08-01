namespace CED.Data.Entities
{
    public class WorkingOrderLineOperationalStatusType
    {
        public string WolstId { get; set; } = null!;

        public byte[] WolstTimeStamp { get; set; } = null!;

        public string WolstName { get; set; } = null!;

        public bool WolstInactive { get; set; }

        public Guid? WolstLocalizableEntryId { get; set; }

        public DateTime WolstCreatedDate { get; set; }

        public string? WolstCreatedBy { get; set; }

        public DateTime WolstLastModifiedDate { get; set; }

        public string? WolstLastModifiedBy { get; set; }

        public virtual LocalizableEntry? WolstLocalizableEntry { get; set; }

        public virtual ICollection<WorkingOrderLineOperationalStatus> WorkingOrderLineOperationalStatuses { get; } =
            new List<WorkingOrderLineOperationalStatus>();
    }
}