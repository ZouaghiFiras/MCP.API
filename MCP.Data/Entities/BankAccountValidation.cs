namespace CED.Data.Entities
{
    public class BankAccountValidation
    {
        public Guid BavId { get; set; }

        public byte[] BavTimeStamp { get; set; } = null!;

        public Guid BavBankAccountId { get; set; }

        public Guid? BavBankAccountAttachmentId { get; set; }

        public Guid? BavEmployeeId { get; set; }

        public DateTime BavStartDate { get; set; }

        public bool BavIsValidated { get; set; }

        public DateTime BavCreatedDate { get; set; }

        public string? BavCreatedBy { get; set; }

        public DateTime BavLastModifiedDate { get; set; }

        public string? BavLastModifiedBy { get; set; }

        public virtual BankAccount BavBankAccount { get; set; } = null!;

        public virtual BankAccountAttachment? BavBankAccountAttachment { get; set; }

        public virtual Employee? BavEmployee { get; set; }
    }
}