namespace CED.Data.Entities
{
    public class RoadAuthorityCode1
    {
        public string RocId { get; set; } = null!;

        public byte[] RocTimeStamp { get; set; } = null!;

        public string RocName { get; set; } = null!;

        public string? RocRoadAuthorityTypeId { get; set; }

        public bool RocInactive { get; set; }

        public Guid? RocLocalizableEntryId { get; set; }

        public DateTime RocCreatedDate { get; set; }

        public string? RocCreatedBy { get; set; }

        public DateTime RocLastModifiedDate { get; set; }

        public string? RocLastModifiedBy { get; set; }

        public virtual ICollection<RoadLocation1> RoadLocation1s { get; } = new List<RoadLocation1>();

        public virtual LocalizableEntry? RocLocalizableEntry { get; set; }

        public virtual RoadAuthorityType? RocRoadAuthorityType { get; set; }
    }
}