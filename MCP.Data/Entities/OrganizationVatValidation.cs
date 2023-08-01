namespace CED.Data.Entities
{
    public class OrganizationVatValidation
    {
        public Guid OavId { get; set; }

        public byte[] OavTimeStamp { get; set; } = null!;

        public Guid OavOrganizationUnitId { get; set; }

        public Guid? OavEmployeeId { get; set; }

        public DateTime OavStartDate { get; set; }

        public bool OavIsValid { get; set; }

        public DateTime OavCreatedDate { get; set; }

        public string? OavCreatedBy { get; set; }

        public DateTime OavLastModifiedDate { get; set; }

        public string? OavLastModifiedBy { get; set; }

        public virtual Employee? OavEmployee { get; set; }

        public virtual OrganizationUnit OavOrganizationUnit { get; set; } = null!;
    }
}