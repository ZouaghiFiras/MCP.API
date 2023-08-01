namespace CED.Data.Entities
{
    public class RoadSection1
    {
        public string RdsId { get; set; } = null!;

        public byte[] RdsTimeStamp { get; set; } = null!;

        public bool RdsIsMainRoadSection { get; set; }

        public bool RdsInactive { get; set; }

        public Guid? RdsLocalizableEntryId { get; set; }

        public DateTime RdsCreatedDate { get; set; }

        public string? RdsCreatedBy { get; set; }

        public DateTime RdsLastModifiedDate { get; set; }

        public string? RdsLastModifiedBy { get; set; }

        public virtual ICollection<AssistancePlanLocation> AssistancePlanLocations { get; } =
            new List<AssistancePlanLocation>();

        public virtual LocalizableEntry? RdsLocalizableEntry { get; set; }

        public virtual ICollection<RoadLocation1> RoadLocation1s { get; } = new List<RoadLocation1>();
    }
}