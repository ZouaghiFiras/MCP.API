namespace CED.Data.Entities
{
    public class Chain
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string Code { get; set; } = null!;

        public string? ShortName { get; set; }

        public string LongName { get; set; } = null!;

        public bool Inactive { get; set; }

        public Guid? LocalizableEntryId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public virtual LocalizableEntry? LocalizableEntry { get; set; }
    }
}