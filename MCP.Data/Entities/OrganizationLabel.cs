namespace CED.Data.Entities
{
    public class OrganizationLabel
    {
        public Guid OulId { get; set; }

        public byte[] OulTimeStamp { get; set; } = null!;

        public Guid OulOrganizationUnitId { get; set; }

        public Guid OulOrganizationLabelTypeId { get; set; }

        public string OulLabel { get; set; } = null!;

        public DateTime? OulValidFromDate { get; set; }

        public DateTime? OulValidUntilDate { get; set; }

        public DateTime OulCreatedDate { get; set; }

        public string? OulCreatedBy { get; set; }

        public DateTime OulLastModifiedDate { get; set; }

        public string? OulLastModifiedBy { get; set; }

        public virtual OrganizationLabelType OulOrganizationLabelType { get; set; } = null!;

        public virtual OrganizationUnit OulOrganizationUnit { get; set; } = null!;
    }
}