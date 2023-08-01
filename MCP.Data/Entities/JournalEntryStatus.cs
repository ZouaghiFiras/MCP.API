namespace CED.Data.Entities
{
    public class JournalEntryStatus
    {
        public Guid JesId { get; set; }

        public byte[] JesTimeStamp { get; set; } = null!;

        public string JesCode { get; set; } = null!;

        public string? JesShortName { get; set; }

        public string JesLongName { get; set; } = null!;

        public bool JesInactive { get; set; }

        public Guid? JesLocalizableEntryId { get; set; }

        public DateTime JesCreatedDate { get; set; }

        public string? JesCreatedBy { get; set; }

        public DateTime JesLastModifiedDate { get; set; }

        public string? JesLastModifiedBy { get; set; }

        public virtual LocalizableEntry? JesLocalizableEntry { get; set; }

        public virtual ICollection<JournalEntryStatusHistory> JournalEntryStatusHistories { get; } =
            new List<JournalEntryStatusHistory>();
    }
}