namespace CED.Data.Entities
{
    public class SalesInvoiceAttachmentsView
    {
        public Guid Id { get; set; }

        public Guid SalesInvoiceId { get; set; }

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

        public string? DossierNumber { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public string? DebtorEmail { get; set; }

        public string? ClientInvoiceDeliveryEmail { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? LegalEntityIban { get; set; }

        public string? ClientReferenceNumber { get; set; }

        public DateTime? InvoiceDueDate { get; set; }

        public bool? IsInternalDocument { get; set; }
    }
}