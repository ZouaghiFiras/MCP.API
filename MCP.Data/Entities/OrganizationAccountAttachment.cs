namespace CED.Data.Entities
{
    public class OrganizationAccountAttachment
    {
        public Guid OaaId { get; set; }

        public byte[] OaaTimeStamp { get; set; } = null!;

        public Guid OaaOrganizationAccountId { get; set; }

        public Guid OaaDocumentId { get; set; }

        public int OaaSequenceNumber { get; set; }

        public DateTime OaaCreatedDate { get; set; }

        public string? OaaCreatedBy { get; set; }

        public DateTime OaaLastModifiedDate { get; set; }

        public string? OaaLastModifiedBy { get; set; }

        public virtual Document OaaDocument { get; set; } = null!;

        public virtual OrganizationAccount OaaOrganizationAccount { get; set; } = null!;

        public virtual ICollection<OrganizationAccountValidation> OrganizationAccountValidations { get; } =
            new List<OrganizationAccountValidation>();
    }
}