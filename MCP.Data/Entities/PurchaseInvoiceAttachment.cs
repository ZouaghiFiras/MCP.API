namespace CED.Data.Entities
{
    public class PurchaseInvoiceAttachment
    {
        public Guid PuaId { get; set; }

        public byte[] PuaTimeStamp { get; set; } = null!;

        public Guid PuaPurchaseInvoiceId { get; set; }

        public Guid PuaDocumentId { get; set; }

        public int PuaSequenceNumber { get; set; }

        public DateTime PuaCreatedDate { get; set; }

        public string? PuaCreatedBy { get; set; }

        public DateTime PuaLastModifiedDate { get; set; }

        public string? PuaLastModifiedBy { get; set; }

        public bool? PuaIsInternalDocument { get; set; }

        public virtual Document PuaDocument { get; set; } = null!;

        public virtual PurchaseInvoice PuaPurchaseInvoice { get; set; } = null!;
    }
}