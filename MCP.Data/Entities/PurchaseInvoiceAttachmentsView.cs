namespace CED.Data.Entities
{
    public class PurchaseInvoiceAttachmentsView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string? Description { get; set; }

        public DateTime DocumentDate { get; set; }

        public string? DocumentNumber { get; set; }

        public string DocumentTypeCode { get; set; } = null!;

        public bool? HasSignature { get; set; }

        public DateTime? SignatureDate { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string CreditorNumber { get; set; } = null!;

        public string? CreditorEmail { get; set; }

        public DateTime? InvoiceDueDate { get; set; }

        public string? LegalEntityIban { get; set; }

        public string LegalEntityName { get; set; } = null!;
    }
}