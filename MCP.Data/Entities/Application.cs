namespace CED.Data.Entities
{
    public class Application
    {
        public Guid AppId { get; set; }

        public byte[] AppTimeStamp { get; set; } = null!;

        public string AppName { get; set; } = null!;

        public string AppNumber { get; set; } = null!;

        public bool AppInactive { get; set; }

        public Guid? AppLocalizableEntryId { get; set; }

        public DateTime AppCreatedDate { get; set; }

        public string? AppCreatedBy { get; set; }

        public DateTime AppLastModifiedDate { get; set; }

        public string? AppLastModifiedBy { get; set; }

        public virtual LocalizableEntry? AppLocalizableEntry { get; set; }

        public virtual ICollection<DossierStatusApplication> DossierStatusApplications { get; } =
            new List<DossierStatusApplication>();

        public virtual ICollection<OrganizationApplication> OrganizationApplications { get; } =
            new List<OrganizationApplication>();

        public virtual ICollection<ProductApplication> ProductApplications { get; } = new List<ProductApplication>();

        public virtual ICollection<ServiceApplication> ServiceApplications { get; } = new List<ServiceApplication>();
    }
}