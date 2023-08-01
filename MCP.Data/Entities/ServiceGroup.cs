namespace CED.Data.Entities
{
    public class ServiceGroup
    {
        public Guid ItgId { get; set; }

        public byte[] ItgTimeStamp { get; set; } = null!;

        public string ItgCode { get; set; } = null!;

        public string? ItgShortName { get; set; }

        public string ItgLongName { get; set; } = null!;

        public bool ItgInactive { get; set; }

        public Guid? ItgLocalizableEntryId { get; set; }

        public DateTime ItgCreatedDate { get; set; }

        public string? ItgCreatedBy { get; set; }

        public DateTime ItgLastModifiedDate { get; set; }

        public string? ItgLastModifiedBy { get; set; }

        public virtual LocalizableEntry? ItgLocalizableEntry { get; set; }

        public virtual ICollection<Service> ServiceItmMainServiceGroups { get; } = new List<Service>();

        public virtual ICollection<Service> ServiceItmSubServiceGroups { get; } = new List<Service>();

        public virtual ICollection<SkillsServiceGroup> SkillsServiceGroups { get; } = new List<SkillsServiceGroup>();
    }
}