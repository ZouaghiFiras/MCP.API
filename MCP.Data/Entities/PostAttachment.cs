namespace CED.Data.Entities
{
    public class PostAttachment
    {
        public Guid PstaId { get; set; }

        public byte[] PstaTimeStamp { get; set; } = null!;

        public Guid PstaPostId { get; set; }

        public Guid PstaDocumentPageId { get; set; }

        public int PstaLineNumber { get; set; }

        public bool? PstaIsInternalDocument { get; set; }

        public DateTime PstaCreatedDate { get; set; }

        public string? PstaCreatedBy { get; set; }

        public DateTime PstaLastModifiedDate { get; set; }

        public string? PstaLastModifiedBy { get; set; }

        public virtual DocumentPage PstaDocumentPage { get; set; } = null!;

        public virtual Post PstaPost { get; set; } = null!;
    }
}