namespace CED.Data.Entities
{
    public class SalesInvoiceAttachment
    {
        public Guid SiaId { get; set; }

        public byte[] SiaTimeStamp { get; set; } = null!;

        public Guid SiaSalesInvoiceId { get; set; }

        public Guid SiaDocumentId { get; set; }

        public int SiaSequenceNumber { get; set; }

        public DateTime SiaCreatedDate { get; set; }

        public string? SiaCreatedBy { get; set; }

        public DateTime SiaLastModifiedDate { get; set; }

        public string? SiaLastModifiedBy { get; set; }

        public bool? SiaIsInternalDocument { get; set; }

        public virtual Document SiaDocument { get; set; } = null!;

        public virtual SalesInvoice SiaSalesInvoice { get; set; } = null!;
    }
}