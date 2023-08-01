namespace CED.Data.Entities
{
    public class RoadAuthorityType1
    {
        public string RotId { get; set; } = null!;

        public byte[] RotTimeStamp { get; set; } = null!;

        public string RotName { get; set; } = null!;

        public bool RotInactive { get; set; }

        public Guid? RotLocalizableEntryId { get; set; }

        public DateTime RotCreatedDate { get; set; }

        public string? RotCreatedBy { get; set; }

        public DateTime RotLastModifiedDate { get; set; }

        public string? RotLastModifiedBy { get; set; }
    }
}