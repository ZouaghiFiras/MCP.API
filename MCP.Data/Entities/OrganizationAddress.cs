namespace CED.Data.Entities
{
    public class OrganizationAddress
    {
        public Guid OadId { get; set; }

        public byte[] OadTimeStamp { get; set; } = null!;

        public Guid OadOrganizationUnitId { get; set; }

        public Guid? OadAddressId { get; set; }

        public Guid? OadPostOfficeBoxId { get; set; }

        public Guid OadAddressTypeId { get; set; }

        public DateTime OadCreatedDate { get; set; }

        public string? OadCreatedBy { get; set; }

        public DateTime OadLastModifiedDate { get; set; }

        public string? OadLastModifiedBy { get; set; }

        public virtual Address? OadAddress { get; set; }

        public virtual AddressType OadAddressType { get; set; } = null!;

        public virtual OrganizationUnit OadOrganizationUnit { get; set; } = null!;

        public virtual PostOfficeBox? OadPostOfficeBox { get; set; }
    }
}