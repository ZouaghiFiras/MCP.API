namespace CED.Data.Entities
{
    public class OrganizationAddress1
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
    }
}