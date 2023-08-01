namespace CED.Data.Entities
{
    public class LocationType
    {
        public Guid LctId { get; set; }

        public byte[] LctTimeStamp { get; set; } = null!;

        public string LctCode { get; set; } = null!;

        public string? LctShortName { get; set; }

        public string LctLongName { get; set; } = null!;

        public bool LctInactive { get; set; }

        public Guid? LctLocalizableEntryId { get; set; }

        public DateTime LctCreatedDate { get; set; }

        public string? LctCreatedBy { get; set; }

        public DateTime LctLastModifiedDate { get; set; }

        public string? LctLastModifiedBy { get; set; }

        public virtual ICollection<AssistancePlanLocation> AssistancePlanLocations { get; } =
            new List<AssistancePlanLocation>();

        public virtual LocalizableEntry? LctLocalizableEntry { get; set; }
    }
}