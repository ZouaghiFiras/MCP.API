namespace CED.Data.Entities
{
    public class Agent
    {
        public Guid AgId { get; set; }

        public byte[] AgTimeStamp { get; set; } = null!;

        public string? AgExternalCode { get; set; }

        public string? AgCultureCodePreferredLanguage { get; set; }

        public bool? AgInactive { get; set; }

        public DateTime AgCreatedDate { get; set; }

        public string? AgCreatedBy { get; set; }

        public DateTime AgLastModifiedDate { get; set; }

        public string? AgLastModifiedBy { get; set; }

        public virtual OrganizationUnit Ag { get; set; } = null!;

        public virtual ICollection<ClientAgent> ClientAgents { get; } = new List<ClientAgent>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; } = new List<InsurancePolicy>();
    }
}