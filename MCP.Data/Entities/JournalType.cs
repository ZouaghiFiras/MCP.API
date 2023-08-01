namespace CED.Data.Entities
{
    public class JournalType
    {
        public string JrtId { get; set; } = null!;

        public byte[] JrtTimeStamp { get; set; } = null!;

        public string? JrtAbbreviation { get; set; }

        public string JrtDescription { get; set; } = null!;

        public short? JrtExactType { get; set; }

        public bool JrtInactive { get; set; }

        public Guid? JrtLocalizableEntryId { get; set; }

        public DateTime JrtCreatedDate { get; set; }

        public string? JrtCreatedBy { get; set; }

        public DateTime JrtLastModifiedDate { get; set; }

        public string? JrtLastModifiedBy { get; set; }

        public virtual ICollection<Journal> Journals { get; } = new List<Journal>();

        public virtual LocalizableEntry? JrtLocalizableEntry { get; set; }
    }
}