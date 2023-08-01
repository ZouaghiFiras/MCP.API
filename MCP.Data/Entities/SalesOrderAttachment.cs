namespace CED.Data.Entities
{
    public class SalesOrderAttachment
    {
        public Guid SoaId { get; set; }

        public byte[] SoaTimeStamp { get; set; } = null!;

        public Guid SoaSalesOrderId { get; set; }

        public Guid SoaDocumentId { get; set; }

        public int SoaSequenceNumber { get; set; }

        public DateTime SoaCreatedDate { get; set; }

        public string? SoaCreatedBy { get; set; }

        public DateTime SoaLastModifiedDate { get; set; }

        public string? SoaLastModifiedBy { get; set; }

        public bool? SoaIsInternalDocument { get; set; }

        public virtual Document SoaDocument { get; set; } = null!;

        public virtual SalesOrder SoaSalesOrder { get; set; } = null!;
    }
}