namespace CED.Data.Entities
{
    public class HierarchyType
    {
        public Guid HtId { get; set; }

        public byte[] HtTimeStamp { get; set; } = null!;

        public string HtCode { get; set; } = null!;

        public string? HtShortName { get; set; }

        public string HtLongName { get; set; } = null!;

        public bool HtInactive { get; set; }

        public Guid? HtLocalizableEntryId { get; set; }

        public DateTime HtCreatedDate { get; set; }

        public string? HtCreatedBy { get; set; }

        public DateTime HtLastModifiedDate { get; set; }

        public string? HtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? HtLocalizableEntry { get; set; }

        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; } = new List<OrganizationUnit>();
    }
}