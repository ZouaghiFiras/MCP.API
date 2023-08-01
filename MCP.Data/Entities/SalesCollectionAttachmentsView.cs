namespace CED.Data.Entities
{
    public class SalesCollectionAttachmentsView
    {
        public Guid Id { get; set; }

        public Guid DocumentId { get; set; }

        public Guid SalesCollectionId { get; set; }

        public string? Description { get; set; }

        public DateTime DocumentDate { get; set; }

        public string? DocumentNumber { get; set; }

        public string DocumentTypeCode { get; set; } = null!;

        public bool HasSignature { get; set; }

        public DateTime? SignatureDate { get; set; }

        public string? MimeType { get; set; }

        public DateTime CollectionDate { get; set; }

        public string CollectionNumber { get; set; } = null!;

        public Guid RecipientDebtorId { get; set; }

        public string? RecipientEmail { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}