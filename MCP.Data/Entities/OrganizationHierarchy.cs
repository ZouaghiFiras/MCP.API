namespace CED.Data.Entities
{
    public class OrganizationHierarchy
    {
        public Guid OhId { get; set; }

        public byte[] OhTimeStamp { get; set; } = null!;

        public Guid OhParentOuId { get; set; }

        public DateTime OhStartDate { get; set; }

        public DateTime? OhEndDate { get; set; }

        public DateTime OhCreatedDate { get; set; }

        public string? OhCreatedBy { get; set; }

        public DateTime OhLastModifiedDate { get; set; }

        public string? OhLastModifiedBy { get; set; }

        public virtual OrganizationUnit Oh { get; set; } = null!;

        public virtual OrganizationUnit OhParentOu { get; set; } = null!;
    }
}