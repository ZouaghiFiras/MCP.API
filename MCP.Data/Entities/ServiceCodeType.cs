namespace CED.Data.Entities
{
    public class ServiceCodeType
    {
        public Guid SctId { get; set; }

        public byte[] SctTimeStamp { get; set; } = null!;

        public string SctCode { get; set; } = null!;

        public string? SctShortName { get; set; }

        public string SctLongName { get; set; } = null!;

        public bool SctInactive { get; set; }

        public Guid? SctLocalizableEntryId { get; set; }

        public DateTime SctCreatedDate { get; set; }

        public string? SctCreatedBy { get; set; }

        public DateTime SctLastModifiedDate { get; set; }

        public string? SctLastModifiedBy { get; set; }

        public virtual LocalizableEntry? SctLocalizableEntry { get; set; }

        public virtual ICollection<ServiceCode> ServiceCodes { get; } = new List<ServiceCode>();
    }
}