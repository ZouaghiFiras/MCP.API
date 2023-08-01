namespace CED.Data.Entities
{
    public class OrganizationPaymentMethod
    {
        public Guid OpmId { get; set; }

        public byte[] OpmTimeStamp { get; set; } = null!;

        public Guid OpmLegalEntityId { get; set; }

        public Guid OpmOrganizationUnitId { get; set; }

        public Guid OpmPaymentMethodId { get; set; }

        public DateTime OpmEffectiveDate { get; set; }

        public DateTime? OpmTerminationDate { get; set; }

        public DateTime OpmCreatedDate { get; set; }

        public string? OpmCreatedBy { get; set; }

        public DateTime OpmLastModifiedDate { get; set; }

        public string? OpmLastModifiedBy { get; set; }

        public virtual LegalEntity OpmLegalEntity { get; set; } = null!;

        public virtual OrganizationUnit OpmOrganizationUnit { get; set; } = null!;

        public virtual PaymentMethod OpmPaymentMethod { get; set; } = null!;
    }
}