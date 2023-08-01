namespace CED.Data.Entities
{
    public class BankStatementLineAttachment
    {
        public Guid BlaId { get; set; }

        public byte[] BlaTimeStamp { get; set; } = null!;

        public Guid BlaBankStatementLineId { get; set; }

        public Guid BlaDocumentId { get; set; }

        public DateTime BlaCreatedDate { get; set; }

        public string? BlaCreatedBy { get; set; }

        public DateTime BlaLastModifiedDate { get; set; }

        public string? BlaLastModifiedBy { get; set; }

        public virtual BankStatementLine BlaBankStatementLine { get; set; } = null!;

        public virtual Document BlaDocument { get; set; } = null!;
    }
}