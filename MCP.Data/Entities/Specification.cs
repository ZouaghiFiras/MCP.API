namespace CED.Data.Entities
{
    public class Specification
    {
        public Guid SpcId { get; set; }

        public byte[] SpcTimeStamp { get; set; } = null!;

        public string SpcCode { get; set; } = null!;

        public string? SpcShortName { get; set; }

        public string SpcLongName { get; set; } = null!;

        public bool SpcInactive { get; set; }

        public Guid? SpcLocalizableEntryId { get; set; }

        public string? SpcCreatedBy { get; set; }

        public DateTime SpcCreatedDate { get; set; }

        public string? SpcLastModifiedBy { get; set; }

        public DateTime SpcLastModifiedDate { get; set; }

        public virtual ICollection<ModelSpecification> ModelSpecifications { get; } = new List<ModelSpecification>();

        public virtual LocalizableEntry? SpcLocalizableEntry { get; set; }
    }
}