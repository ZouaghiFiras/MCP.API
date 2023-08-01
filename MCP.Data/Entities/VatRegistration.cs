namespace CED.Data.Entities
{
    public class VatRegistration
    {
        public Guid VtrId { get; set; }

        public byte[] VtrTimeStamp { get; set; } = null!;

        public string VtrVatNumber { get; set; } = null!;

        public string VtrLegalName { get; set; } = null!;

        public string VtrCountryCode { get; set; } = null!;

        public bool? VtrInactive { get; set; }

        public DateTime VtrCreatedDate { get; set; }

        public string? VtrCreatedBy { get; set; }

        public DateTime VtrLastModifiedDate { get; set; }

        public string? VtrLastModifiedBy { get; set; }

        public virtual ICollection<OrganizationVatRegistration> OrganizationVatRegistrations { get; } =
            new List<OrganizationVatRegistration>();
    }
}