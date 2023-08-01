namespace CED.Data.Entities
{
    public class ConvenantParty
    {
        public Guid CovId { get; set; }

        public byte[] CovTimeStamp { get; set; } = null!;

        public string? CovConvenantNumber { get; set; }

        public bool? CovInactive { get; set; }

        public DateTime CovCreatedDate { get; set; }

        public string? CovCreatedBy { get; set; }

        public DateTime CovLastModifiedDate { get; set; }

        public string? CovLastModifiedBy { get; set; }

        public virtual OrganizationUnit Cov { get; set; } = null!;
    }
}