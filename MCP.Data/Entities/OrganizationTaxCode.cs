namespace CED.Data.Entities
{
    public class OrganizationTaxCode
    {
        public Guid OtcId { get; set; }

        public byte[] OtcTimeStamp { get; set; } = null!;

        public Guid OtcOrganizationUnitId { get; set; }

        public Guid OtcLegalEntityId { get; set; }

        public string OtcTaxCodeId { get; set; } = null!;

        public DateTime OtcEffectiveDate { get; set; }

        public DateTime? OtcTerminationDate { get; set; }

        public DateTime OtcCreatedDate { get; set; }

        public string? OtcCreatedBy { get; set; }

        public DateTime OtcLastModifiedDate { get; set; }

        public string? OtcLastModifiedBy { get; set; }

        public virtual LegalEntity OtcLegalEntity { get; set; } = null!;

        public virtual OrganizationUnit OtcOrganizationUnit { get; set; } = null!;
    }
}