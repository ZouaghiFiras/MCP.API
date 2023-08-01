namespace CED.Data.Entities
{
    public class ServiceType
    {
        public Guid SetId { get; set; }

        public byte[] SetTimeStamp { get; set; } = null!;

        public string SetCode { get; set; } = null!;

        public string? SetShortName { get; set; }

        public string SetLongName { get; set; } = null!;

        public bool SetInactive { get; set; }

        public DateTime SetCreatedDate { get; set; }

        public string? SetCreatedBy { get; set; }

        public DateTime SetLastModifiedDate { get; set; }

        public string? SetLastModifiedBy { get; set; }

        public Guid? SetLocalizableEntryId { get; set; }

        public virtual LocalizedEntry? SetLocalizableEntry { get; set; }
    }
}