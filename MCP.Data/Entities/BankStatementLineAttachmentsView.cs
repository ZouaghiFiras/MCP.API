namespace CED.Data.Entities
{
    public class BankStatementLineAttachmentsView
    {
        public Guid Id { get; set; }

        public Guid BankStatementLineId { get; set; }

        public Guid BankStatementId { get; set; }

        public int SequenceNumber { get; set; }

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

        public byte[] TimeStamp { get; set; } = null!;
    }
}