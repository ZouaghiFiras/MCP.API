namespace CED.Data.Entities
{
    public class SalesCollectionStatus
    {
        public Guid ScsId { get; set; }

        public byte[] ScsTimeStamp { get; set; } = null!;

        public string ScsCode { get; set; } = null!;

        public string? ScsShortName { get; set; }

        public string ScsLongName { get; set; } = null!;

        public bool ScsInactive { get; set; }

        public Guid? ScsLocalizableEntryId { get; set; }

        public DateTime ScsCreatedDate { get; set; }

        public string? ScsCreatedBy { get; set; }

        public DateTime ScsLastModifiedDate { get; set; }

        public string? ScsLastModifiedBy { get; set; }

        public virtual ICollection<SalesCollectionStatusHistory> SalesCollectionStatusHistories { get; } =
            new List<SalesCollectionStatusHistory>();

        public virtual LocalizableEntry? ScsLocalizableEntry { get; set; }
    }
}