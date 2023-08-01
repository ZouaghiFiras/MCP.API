namespace CED.Data.Entities
{
    public class UnitOfMeasureType
    {
        public Guid UomtId { get; set; }

        public byte[] UomtTimeStamp { get; set; } = null!;

        public string UomtCode { get; set; } = null!;

        public string? UomtShortName { get; set; }

        public string UomtLongName { get; set; } = null!;

        public bool UomtInactive { get; set; }

        public Guid? UomtLocalizableEntryId { get; set; }

        public DateTime UomtCreatedDate { get; set; }

        public string? UomtCreatedBy { get; set; }

        public DateTime UomtLastModifiedDate { get; set; }

        public string? UomtLastModifiedBy { get; set; }

        public virtual ICollection<UnitOfMeasure> UnitOfMeasures { get; } = new List<UnitOfMeasure>();

        public virtual LocalizableEntry? UomtLocalizableEntry { get; set; }
    }
}