namespace CED.Data.Entities
{
    public class ModelSpecification
    {
        public Guid MdsId { get; set; }

        public byte[] MdsTimeStamp { get; set; } = null!;

        public Guid MdsModelId { get; set; }

        public Guid MdsSpecificationId { get; set; }

        public bool MdsInactive { get; set; }

        public Guid? MdsLocalizableEntryId { get; set; }

        public string? MdsCreatedBy { get; set; }

        public DateTime MdsCreatedDate { get; set; }

        public string? MdsLastModifiedBy { get; set; }

        public DateTime MdsLastModifiedDate { get; set; }

        public virtual LocalizableEntry? MdsLocalizableEntry { get; set; }

        public virtual Model MdsModel { get; set; } = null!;

        public virtual Specification MdsSpecification { get; set; } = null!;
    }
}