namespace CED.Data.Entities
{
    public class ContactPersonType
    {
        public Guid CptId { get; set; }

        public byte[] CptTimeStamp { get; set; } = null!;

        public string CptCode { get; set; } = null!;

        public string? CptShortName { get; set; }

        public string CptLongName { get; set; } = null!;

        public bool CptInactive { get; set; }

        public Guid? CptLocalizableEntryId { get; set; }

        public DateTime CptCreatedDate { get; set; }

        public string? CptCreatedBy { get; set; }

        public DateTime CptLastModifiedDate { get; set; }

        public string? CptLastModifiedBy { get; set; }

        public virtual ICollection<ContactPerson> ContactPeople { get; } = new List<ContactPerson>();

        public virtual LocalizableEntry? CptLocalizableEntry { get; set; }

        public virtual ICollection<DossierContactPerson> DossierContactPeople { get; } =
            new List<DossierContactPerson>();
    }
}