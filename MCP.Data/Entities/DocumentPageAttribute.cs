namespace CED.Data.Entities
{
    public class DocumentPageAttribute
    {
        public Guid DpaId { get; set; }

        public byte[] DpaTimeStamp { get; set; } = null!;

        public Guid DpaDocumentPageId { get; set; }

        public string DpaAttributeName { get; set; } = null!;

        public string DpaAttributeContent { get; set; } = null!;

        public DateTime DpaCreatedDate { get; set; }

        public string? DpaCreatedBy { get; set; }

        public DateTime DpaLastModifiedDate { get; set; }

        public string? DpaLastModifiedBy { get; set; }

        public virtual DocumentPage DpaDocumentPage { get; set; } = null!;
    }
}