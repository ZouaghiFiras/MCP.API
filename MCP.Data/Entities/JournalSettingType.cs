namespace CED.Data.Entities
{
    public class JournalSettingType
    {
        public string JltId { get; set; } = null!;

        public byte[] JltTimeStamp { get; set; } = null!;

        public string JltDescription { get; set; } = null!;

        public bool JltInactive { get; set; }

        public Guid? JltLocalizableEntryId { get; set; }

        public DateTime JltCreatedDate { get; set; }

        public string? JltCreatedBy { get; set; }

        public DateTime JltLastModifiedDate { get; set; }

        public string? JltLastModifiedBy { get; set; }

        public virtual LocalizableEntry? JltLocalizableEntry { get; set; }

        public virtual ICollection<JournalSetting> JournalSettings { get; } = new List<JournalSetting>();
    }
}