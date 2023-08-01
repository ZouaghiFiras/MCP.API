namespace CED.Data.Entities
{
    public class DocumentAttribute1
    {
        public Guid DcaId { get; set; }

        public byte[] DcaTimeStamp { get; set; } = null!;

        public Guid DcaDocumentId { get; set; }

        public string DcaAttributeName { get; set; } = null!;

        public string DcaAttributeContent { get; set; } = null!;

        public DateTime DcaCreatedDate { get; set; }

        public string? DcaCreatedBy { get; set; }

        public DateTime DcaLastModifiedDate { get; set; }

        public string? DcaLastModifiedBy { get; set; }
    }
}