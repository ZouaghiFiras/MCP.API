namespace CED.Data.Entities
{
    public class DossierInsuree
    {
        public Guid DoiId { get; set; }

        public byte[] DoiTimeStamp { get; set; } = null!;

        public Guid DoiDossierId { get; set; }

        public Guid DoiDossierPartyId { get; set; }

        public string? DoiPolicyNumber { get; set; }

        public string? DoiInitials { get; set; }

        public string? DoiFirstName { get; set; }

        public string? DoiPrefixLastName { get; set; }

        public string? DoiLastName { get; set; }

        public string DoiFormattedName { get; set; } = null!;

        public string? DoiStreetName { get; set; }

        public string? DoiHouseNumber { get; set; }

        public string? DoiHouseNumberAddition { get; set; }

        public string? DoiPostalCode { get; set; }

        public string? DoiCity { get; set; }

        public string DoiCountryCodeIso3 { get; set; } = null!;

        public string? DoiFormattedAddress { get; set; }

        public DateTime? DoiDateOfBirth { get; set; }

        public bool DoiInactive { get; set; }

        public DateTime DoiCreatedDate { get; set; }

        public string? DoiCreatedBy { get; set; }

        public DateTime DoiLastModifiedDate { get; set; }

        public string? DoiLastModifiedBy { get; set; }

        public virtual Dossier DoiDossier { get; set; } = null!;

        public virtual DossierParty DoiDossierParty { get; set; } = null!;

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; } = new List<InsurancePolicy>();
    }
}