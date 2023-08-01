namespace CED.Data.Entities
{
    public class BankAccountAttachment
    {
        public Guid BaaId { get; set; }

        public byte[] BaaTimeStamp { get; set; } = null!;

        public Guid BaaBankAccountId { get; set; }

        public Guid BaaDocumentId { get; set; }

        public int BaaSequenceNumber { get; set; }

        public DateTime BaaCreatedDate { get; set; }

        public string? BaaCreatedBy { get; set; }

        public DateTime BaaLastModifiedDate { get; set; }

        public string? BaaLastModifiedBy { get; set; }

        public virtual BankAccount BaaBankAccount { get; set; } = null!;

        public virtual Document BaaDocument { get; set; } = null!;

        public virtual ICollection<BankAccountValidation> BankAccountValidations { get; } =
            new List<BankAccountValidation>();
    }
}