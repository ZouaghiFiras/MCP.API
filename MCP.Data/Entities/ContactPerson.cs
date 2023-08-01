namespace CED.Data.Entities
{
    public class ContactPerson
    {
        public Guid CpId { get; set; }

        public byte[] CpTimeStamp { get; set; } = null!;

        public Guid CpOrganizationUnitId { get; set; }

        public Guid CpContactPersonTypeId { get; set; }

        public string CpFullName { get; set; } = null!;

        public short CpGenderId { get; set; }

        public string? CpEmail { get; set; }

        public string? CpMobile { get; set; }

        public string? CpPhone { get; set; }

        public string? CpFax { get; set; }

        public string? CpCultureCodePreferredLanguage { get; set; }

        public bool CpInactive { get; set; }

        public DateTime CpCreatedDate { get; set; }

        public string? CpCreatedBy { get; set; }

        public DateTime CpLastModifiedDate { get; set; }

        public string? CpLastModifiedBy { get; set; }

        public string? CpIntakeMethod { get; set; }

        public Guid? CpSalutationId { get; set; }

        public virtual ContactPersonType CpContactPersonType { get; set; } = null!;

        public virtual Gender CpGender { get; set; } = null!;

        public virtual OrganizationUnit CpOrganizationUnit { get; set; } = null!;

        public virtual ICollection<DossierContactPerson> DossierContactPeople { get; } =
            new List<DossierContactPerson>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();
    }
}