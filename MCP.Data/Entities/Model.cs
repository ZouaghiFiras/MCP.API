namespace CED.Data.Entities
{
    public class Model
    {
        public Guid MdlId { get; set; }

        public byte[] MdlTimeStamp { get; set; } = null!;

        public string MdlCode { get; set; } = null!;

        public string? MdlShortName { get; set; }

        public string MdlLongName { get; set; } = null!;

        public Guid MdlBrandId { get; set; }

        public Guid? MdlInsuranceObjectId { get; set; }

        public bool MdlInactive { get; set; }

        public Guid? MdlLocalizableEntryId { get; set; }

        public string? MdlCreatedBy { get; set; }

        public DateTime MdlCreatedDate { get; set; }

        public string? MdlLastModifiedBy { get; set; }

        public DateTime MdlLastModifiedDate { get; set; }

        public virtual Brand MdlBrand { get; set; } = null!;

        public virtual InsuranceObject? MdlInsuranceObject { get; set; }

        public virtual LocalizableEntry? MdlLocalizableEntry { get; set; }

        public virtual ICollection<ModelProduct> ModelProducts { get; } = new List<ModelProduct>();

        public virtual ICollection<ModelSpecification> ModelSpecifications { get; } = new List<ModelSpecification>();
    }
}