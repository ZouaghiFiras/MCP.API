namespace CED.Data.Entities
{
    public class RoadAuthority
    {
        public Guid RaId { get; set; }

        public byte[] RaTimeStamp { get; set; } = null!;

        public string? RaExternalCode { get; set; }

        public string? RaCultureCodePreferredLanguage { get; set; }

        public string? RaRoadAuthorityTypeId { get; set; }

        public bool? RaInactive { get; set; }

        public DateTime RaCreatedDate { get; set; }

        public string? RaCreatedBy { get; set; }

        public DateTime RaLastModifiedDate { get; set; }

        public string? RaLastModifiedBy { get; set; }

        public virtual ICollection<AssistanceDossier> AssistanceDossiers { get; } = new List<AssistanceDossier>();

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; } = new List<InsurancePolicy>();

        public virtual OrganizationUnit Ra { get; set; } = null!;

        public virtual RoadAuthorityType? RaRoadAuthorityType { get; set; }
    }
}