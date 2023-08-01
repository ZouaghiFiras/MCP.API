namespace CED.Data.Entities
{
    public class ContactType
    {
        public Guid CotId { get; set; }

        public byte[] CotTimeStamp { get; set; } = null!;

        public string CotCode { get; set; } = null!;

        public string? CotShortName { get; set; }

        public string CotLongName { get; set; } = null!;

        public bool CotInactive { get; set; }

        public Guid? CotLocalizableEntryId { get; set; }

        public DateTime CotCreatedDate { get; set; }

        public string? CotCreatedBy { get; set; }

        public DateTime CotLastModifiedDate { get; set; }

        public string? CotLastModifiedBy { get; set; }

        public virtual LocalizableEntry? CotLocalizableEntry { get; set; }

        public virtual ICollection<OrganizationContact> OrganizationContacts { get; } = new List<OrganizationContact>();
    }
}