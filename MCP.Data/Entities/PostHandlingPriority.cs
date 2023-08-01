namespace CED.Data.Entities
{
    public class PostHandlingPriority
    {
        public Guid PhpId { get; set; }

        public byte[] PhpTimeStamp { get; set; } = null!;

        public string PhpName { get; set; } = null!;

        public int PhpPriority { get; set; }

        public bool PhpInactive { get; set; }

        public Guid? PhpLocalizableEntryId { get; set; }

        public DateTime PhpCreatedDate { get; set; }

        public string? PhpCreatedBy { get; set; }

        public DateTime PhpLastModifiedDate { get; set; }

        public string? PhpLastModifiedBy { get; set; }

        public virtual LocalizableEntry? PhpLocalizableEntry { get; set; }

        public virtual ICollection<Post> Posts { get; } = new List<Post>();
    }
}