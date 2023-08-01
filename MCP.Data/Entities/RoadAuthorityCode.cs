namespace CED.Data.Entities
{
    public class RoadAuthorityCode
    {
        public string RocId { get; set; } = null!;

        public string RocName { get; set; } = null!;

        public string? RocRoadAuthorityTypeId { get; set; }

        public bool RocInactive { get; set; }

        public Guid? RocLocalizableEntryId { get; set; }

        public DateTime RocCreatedDate { get; set; }

        public string? RocCreatedBy { get; set; }

        public DateTime RocLastModifiedDate { get; set; }

        public string? RocLastModifiedBy { get; set; }
    }
}