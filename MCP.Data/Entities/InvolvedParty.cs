namespace CED.Data.Entities
{
    public class InvolvedParty
    {
        public Guid IpaId { get; set; }

        public byte[] IpaTimeStamp { get; set; } = null!;

        public string? IpaPartyNumber { get; set; }

        public string? IpaInitials { get; set; }

        public string? IpaFirstName { get; set; }

        public string? IpaPrefixLastName { get; set; }

        public string? IpaLastName { get; set; }

        public string IpaFullName { get; set; } = null!;

        public string? IpaIban { get; set; }

        public string? IpaBic { get; set; }

        public long? IpaBankAccountNumber { get; set; }

        public string? IpaStreetName { get; set; }

        public string? IpaHouseNumber { get; set; }

        public string? IpaHouseNumberAddition { get; set; }

        public string? IpaPostalCode { get; set; }

        public string? IpaCity { get; set; }

        public string? IpaProvince { get; set; }

        public string IpaCountryCode { get; set; } = null!;

        public string? IpaFullAddress { get; set; }

        public string? IpaPhoneNumber { get; set; }

        public string? IpaEmail { get; set; }

        public DateTime? IpaDateOfBirth { get; set; }

        public string? IpaPartyGender { get; set; }

        public bool? IpaIsTaxExempted { get; set; }

        public string? IpaExemptNumber { get; set; }

        public DateTime IpaCreatedDate { get; set; }

        public string? IpaCreatedBy { get; set; }

        public DateTime IpaLastModifiedDate { get; set; }

        public string? IpaLastModifiedBy { get; set; }

        public string? IpaMiddleName { get; set; }

        public string? IpaPhoneNumber2 { get; set; }

        public string? IpaPhoneNumber3 { get; set; }

        public string? IpaCocNumber { get; set; }

        public string? IpaReference { get; set; }

        public bool? IpaIsHomeOwnerAssociation { get; set; }

        public Guid? IpaSalutationId { get; set; }

        public bool? IpaIsCompany { get; set; }

        public string? IpaVatNumber { get; set; }

        public bool IpaInactive { get; set; }

        public string? IpaBsnCitizenServiceNumber { get; set; }

        public virtual ICollection<DossierParty> DossierParties { get; } = new List<DossierParty>();

        public virtual Salutation? IpaSalutation { get; set; }

        public virtual ICollection<VisitInformation> VisitInformations { get; } = new List<VisitInformation>();
    }
}