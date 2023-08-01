namespace CED.Data.Entities
{
    public class SalesOrderAttachmentsView
    {
        public Guid Id { get; set; }

        public Guid SalesOrderId { get; set; }

        public string? Description { get; set; }

        public DateTime DocumentDate { get; set; }

        public string? DocumentNumber { get; set; }

        public string DocumentTypeCode { get; set; } = null!;

        public bool HasSignature { get; set; }

        public DateTime? SignatureDate { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        public string OrderNumber { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}