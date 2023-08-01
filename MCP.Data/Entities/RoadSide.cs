namespace CED.Data.Entities
{
    public class RoadSide
    {
        public string RsdId { get; set; } = null!;

        public byte[] RsdTimeStamp { get; set; } = null!;

        public string RsdName { get; set; } = null!;

        public bool RsdInactive { get; set; }

        public Guid? RsdLocalizableEntryId { get; set; }

        public DateTime RsdCreatedDate { get; set; }

        public string? RsdCreatedBy { get; set; }

        public DateTime RsdLastModifiedDate { get; set; }

        public string? RsdLastModifiedBy { get; set; }

        public virtual ICollection<RoadLocation1> RoadLocation1s { get; } = new List<RoadLocation1>();

        public virtual LocalizableEntry? RsdLocalizableEntry { get; set; }
    }
}