namespace CED.Data.Entities
{
    public class LocalizedEntry
    {
        public Guid LlcId { get; set; }

        public byte[] LlcTimeStamp { get; set; } = null!;

        public Guid LlcLocalizableEntryId { get; set; }

        public string LlcCultureCode { get; set; } = null!;

        public string? LlcShortTranslation { get; set; }

        public string LlcLongTranslation { get; set; } = null!;

        public DateTime LlcCreatedDate { get; set; }

        public string? LlcCreatedBy { get; set; }

        public DateTime LlcLastModifiedDate { get; set; }

        public string? LlcLastModifiedBy { get; set; }

        public virtual LocalizableEntry LlcLocalizableEntry { get; set; } = null!;

        public virtual ICollection<ServiceType> ServiceTypes { get; } = new List<ServiceType>();
    }
}