namespace CED.Data.Entities
{
    public class HandlingType
    {
        public short HntId { get; set; }

        public byte[] HntTimeStamp { get; set; } = null!;

        public string HntCode { get; set; } = null!;

        public string? HntShortName { get; set; }

        public string HntLongName { get; set; } = null!;

        public bool HntInactive { get; set; }

        public Guid? HntLocalizableEntryId { get; set; }

        public DateTime HntCreatedDate { get; set; }

        public string? HntCreatedBy { get; set; }

        public DateTime HntLastModifiedDate { get; set; }

        public string? HntLastModifiedBy { get; set; }

        public virtual ICollection<HandlingCountry> HandlingCountries { get; } = new List<HandlingCountry>();

        public virtual LocalizableEntry? HntLocalizableEntry { get; set; }
    }
}