namespace CED.Data.Entities
{
    public class WorkingOrderLineOperationalStatus
    {
        public Guid WolosId { get; set; }

        public byte[] WolosTimeStamp { get; set; } = null!;

        public string WolosCode { get; set; } = null!;

        public string? WolosShortName { get; set; }

        public string WolosLongName { get; set; } = null!;

        public bool WolosInactive { get; set; }

        public string? WolosWorkingOrderLineOperationalStatusTypeId { get; set; }

        public Guid? WolosLocalizableEntryId { get; set; }

        public DateTime WolosCreatedDate { get; set; }

        public string? WolosCreatedBy { get; set; }

        public DateTime WolosLastModifiedDate { get; set; }

        public string? WolosLastModifiedBy { get; set; }

        public virtual LocalizableEntry? WolosLocalizableEntry { get; set; }

        public virtual WorkingOrderLineOperationalStatusType? WolosWorkingOrderLineOperationalStatusType { get; set; }

        public virtual ICollection<WorkingOrderLineOperationalStatusHistory>
            WorkingOrderLineOperationalStatusHistories { get; } = new List<WorkingOrderLineOperationalStatusHistory>();
    }
}