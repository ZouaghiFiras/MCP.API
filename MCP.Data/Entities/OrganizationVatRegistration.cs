namespace CED.Data.Entities
{
    public class OrganizationVatRegistration
    {
        public Guid OvrId { get; set; }

        public byte[] OvrTimeStamp { get; set; } = null!;

        public Guid OvrOrganizationUnitId { get; set; }

        public Guid OvrVatRegistrationId { get; set; }

        public DateTime OvrEffectiveDate { get; set; }

        public DateTime? OvrTerminationDate { get; set; }

        public DateTime OvrCreatedDate { get; set; }

        public string? OvrCreatedBy { get; set; }

        public DateTime OvrLastModifiedDate { get; set; }

        public string? OvrLastModifiedBy { get; set; }

        public virtual OrganizationUnit OvrOrganizationUnit { get; set; } = null!;

        public virtual VatRegistration OvrVatRegistration { get; set; } = null!;
    }
}