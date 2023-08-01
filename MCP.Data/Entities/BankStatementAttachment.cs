namespace CED.Data.Entities
{
    public class BankStatementAttachment
    {
        public Guid BsaId { get; set; }

        public byte[] BsaTimeStamp { get; set; } = null!;

        public Guid BsaBankStatementId { get; set; }

        public Guid BsaDocumentId { get; set; }

        public DateTime BsaCreatedDate { get; set; }

        public string? BsaCreatedBy { get; set; }

        public DateTime BsaLastModifiedDate { get; set; }

        public string? BsaLastModifiedBy { get; set; }

        public virtual BankStatement BsaBankStatement { get; set; } = null!;

        public virtual Document BsaDocument { get; set; } = null!;
    }
}