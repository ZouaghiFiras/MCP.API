namespace CED.Data.Entities
{
    public class InsuranceProductType
    {
        public Guid IptId { get; set; }

        public byte[] IptTimeStamp { get; set; } = null!;

        public string IptCode { get; set; } = null!;

        public string? IptShortName { get; set; }

        public string IptLongName { get; set; } = null!;

        public bool IptInactive { get; set; }

        public Guid? IptLocalizableEntryId { get; set; }

        public DateTime IptCreatedDate { get; set; }

        public string? IptCreatedBy { get; set; }

        public DateTime IptLastModifiedDate { get; set; }

        public string? IptLastModifiedBy { get; set; }

        public virtual LocalizableEntry? IptLocalizableEntry { get; set; }
    }
}