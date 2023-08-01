namespace CED.Data.Entities
{
    public class SalesCollectionAttachment
    {
        public Guid ScaId { get; set; }

        public byte[] ScaTimeStamp { get; set; } = null!;

        public Guid ScaSalesCollectionId { get; set; }

        public Guid ScaDocumentId { get; set; }

        public int ScaSequenceNumber { get; set; }

        public DateTime ScaCreatedDate { get; set; }

        public string? ScaCreatedBy { get; set; }

        public DateTime ScaLastModifiedDate { get; set; }

        public string? ScaLastModifiedBy { get; set; }

        public virtual Document ScaDocument { get; set; } = null!;

        public virtual SalesCollection ScaSalesCollection { get; set; } = null!;
    }
}