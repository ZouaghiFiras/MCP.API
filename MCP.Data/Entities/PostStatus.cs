namespace CED.Data.Entities
{
    public class PostStatus
    {
        public Guid PtstId { get; set; }

        public byte[] PtstTimeStamp { get; set; } = null!;

        public string PtstCode { get; set; } = null!;

        public string? PtstShortName { get; set; }

        public string PtstLongName { get; set; } = null!;

        public bool PtstInactive { get; set; }

        public Guid? PtstLocalizableEntryId { get; set; }

        public DateTime PtstCreatedDate { get; set; }

        public string? PtstCreatedBy { get; set; }

        public DateTime PtstLastModifiedDate { get; set; }

        public string? PtstLastModifiedBy { get; set; }

        public virtual ICollection<PostStatusHistory> PostStatusHistories { get; } = new List<PostStatusHistory>();

        public virtual LocalizableEntry? PtstLocalizableEntry { get; set; }
    }
}