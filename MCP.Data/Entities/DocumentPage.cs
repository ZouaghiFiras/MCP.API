namespace CED.Data.Entities
{
    public class DocumentPage
    {
        public Guid DpgId { get; set; }

        public byte[] DpgTimeStamp { get; set; } = null!;

        public Guid DpgDocumentId { get; set; }

        public int DpgPageNumber { get; set; }

        public DateTime DpgCreatedDate { get; set; }

        public string? DpgCreatedBy { get; set; }

        public DateTime DpgLastModifiedDate { get; set; }

        public string? DpgLastModifiedBy { get; set; }

        public virtual ICollection<DocumentPageAttribute> DocumentPageAttributes { get; } =
            new List<DocumentPageAttribute>();

        public virtual Document DpgDocument { get; set; } = null!;

        public virtual ICollection<PostAttachment> PostAttachments { get; } = new List<PostAttachment>();
    }
}