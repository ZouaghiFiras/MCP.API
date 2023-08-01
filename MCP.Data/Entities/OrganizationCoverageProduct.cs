namespace CED.Data.Entities
{
    public class OrganizationCoverageProduct
    {
        public Guid OcpId { get; set; }

        public byte[] OcpTimeStamp { get; set; } = null!;

        public string? OcpName { get; set; }

        public string? OcpSpecificInformation { get; set; }

        public bool OcpInactive { get; set; }

        public DateTime OcpStartDate { get; set; }

        public DateTime? OcpEndDate { get; set; }

        public string? OcpPolisCheckTelephoneNr { get; set; }

        public string? OcpPolisCheckAlternateTelephone { get; set; }

        public string? OcpPolisCheckPortalWebsite { get; set; }

        public bool? OcpHasCustomCommunication { get; set; }

        public string? OcpDeviantBillingParty { get; set; }

        public Guid OcpOrganizationUnitId { get; set; }

        public Guid OcpCoverageProductId { get; set; }

        public DateTime OcpCreatedDate { get; set; }

        public string? OcpCreatedBy { get; set; }

        public DateTime OcpLastModifiedDate { get; set; }

        public string? OcpLastModifiedBy { get; set; }

        public virtual CoverageProduct OcpCoverageProduct { get; set; } = null!;

        public virtual OrganizationUnit OcpOrganizationUnit { get; set; } = null!;

        public virtual OrganizationCoverageProductsExtension? OrganizationCoverageProductsExtension { get; set; }
    }
}