namespace CED.Data.Entities
{
    public class WorkingOrderLineAttachmentsView
    {
        public Guid Id { get; set; }

        public Guid WorkingOrderLineAttachmentId { get; set; }

        public Guid WorkingOrderLineId { get; set; }

        public string? Description { get; set; }

        public DateTime DocumentDate { get; set; }

        public string? DocumentNumber { get; set; }

        public string DocumentTypeCode { get; set; } = null!;

        public bool HasSignature { get; set; }

        public DateTime? SignatureDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}