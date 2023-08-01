namespace CED.Data.Entities
{
    public class OrganizationGroup
    {
        public Guid OgId { get; set; }

        public byte[] OgTimeStamp { get; set; } = null!;

        public string OgCode { get; set; } = null!;

        public string? OgShortName { get; set; }

        public string OgLongName { get; set; } = null!;

        public bool OgInactive { get; set; }

        public Guid? OgLocalizableEntryId { get; set; }

        public DateTime OgCreatedDate { get; set; }

        public string? OgCreatedBy { get; set; }

        public DateTime OgLastModifiedDate { get; set; }

        public string? OgLastModifiedBy { get; set; }

        public virtual LocalizableEntry? OgLocalizableEntry { get; set; }

        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; } = new List<OrganizationUnit>();
    }
}