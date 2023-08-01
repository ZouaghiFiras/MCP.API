namespace CED.Data.Entities
{
    public class Mandate
    {
        public Guid MdId { get; set; }

        public byte[] MdTimeStamp { get; set; } = null!;

        public string? MdCultureCodePreferredLanguage { get; set; }

        public bool? MdInactive { get; set; }

        public DateTime MdCreatedDate { get; set; }

        public string? MdCreatedBy { get; set; }

        public DateTime MdLastModifiedDate { get; set; }

        public string? MdLastModifiedBy { get; set; }

        public virtual ICollection<ClientMandate> ClientMandates { get; } = new List<ClientMandate>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; } = new List<InsurancePolicy>();

        public virtual ICollection<MandateAlarmCenter> MandateAlarmCenters { get; } = new List<MandateAlarmCenter>();

        public virtual OrganizationUnit Md { get; set; } = null!;
    }
}