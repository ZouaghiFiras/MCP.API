namespace CED.Data.Entities
{
    public class RoadType
    {
        public string RdtId { get; set; } = null!;

        public byte[] RdtTimeStamp { get; set; } = null!;

        public string RdtName { get; set; } = null!;

        public bool RdtInactive { get; set; }

        public Guid? RdtLocalizableEntryId { get; set; }

        public DateTime RdtCreatedDate { get; set; }

        public string? RdtCreatedBy { get; set; }

        public DateTime RdtLastModifiedDate { get; set; }

        public string? RdtLastModifiedBy { get; set; }

        public virtual ICollection<AssistancePlanLocation> AssistancePlanLocations { get; } =
            new List<AssistancePlanLocation>();

        public virtual LocalizableEntry? RdtLocalizableEntry { get; set; }

        public virtual ICollection<RoadLocation1> RoadLocation1s { get; } = new List<RoadLocation1>();
    }
}