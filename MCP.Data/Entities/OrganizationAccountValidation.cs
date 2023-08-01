namespace CED.Data.Entities
{
    public class OrganizationAccountValidation
    {
        public Guid OavId { get; set; }

        public byte[] OavTimeStamp { get; set; } = null!;

        public Guid OavOrganizationAccountId { get; set; }

        public Guid? OavOrganizationAccountAttachmentId { get; set; }

        public Guid? OavEmployeeId { get; set; }

        public DateTime OavStartDate { get; set; }

        public bool OavIsApproved { get; set; }

        public DateTime OavCreatedDate { get; set; }

        public string? OavCreatedBy { get; set; }

        public DateTime OavLastModifiedDate { get; set; }

        public string? OavLastModifiedBy { get; set; }

        public virtual Employee? OavEmployee { get; set; }

        public virtual OrganizationAccount OavOrganizationAccount { get; set; } = null!;

        public virtual OrganizationAccountAttachment? OavOrganizationAccountAttachment { get; set; }
    }
}