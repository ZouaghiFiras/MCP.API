namespace CED.Data.Entities
{
    public class Application1
    {
        public Guid AppId { get; set; }

        public byte[] AppTimeStamp { get; set; } = null!;

        public string AppName { get; set; } = null!;

        public string AppNumber { get; set; } = null!;

        public bool AppInactive { get; set; }

        public Guid? AppLocalizableEntryId { get; set; }

        public DateTime AppCreatedDate { get; set; }

        public string? AppCreatedBy { get; set; }

        public DateTime AppLastModifiedDate { get; set; }

        public string? AppLastModifiedBy { get; set; }
    }
}