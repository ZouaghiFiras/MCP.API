namespace CED.Data.Entities
{
    public class PostTag
    {
        public Guid PstaId { get; set; }

        public byte[] PstaTimeStamp { get; set; } = null!;

        public Guid PstaPostId { get; set; }

        public string PstaTag { get; set; } = null!;

        public DateTime PstaCreatedDate { get; set; }

        public string? PstaCreatedBy { get; set; }

        public DateTime PstaLastModifiedDate { get; set; }

        public string? PstaLastModifiedBy { get; set; }

        public virtual Post PstaPost { get; set; } = null!;
    }
}