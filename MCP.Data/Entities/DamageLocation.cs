namespace CED.Data.Entities
{
    public class DamageLocation
    {
        public Guid DlId { get; set; }

        public byte[] DlTimeStamp { get; set; } = null!;

        public string DlCode { get; set; } = null!;

        public string? DlShortName { get; set; }

        public string DlLongName { get; set; } = null!;

        public bool DlInactive { get; set; }

        public Guid? DlLocalizableEntryId { get; set; }

        public DateTime DlCreatedDate { get; set; }

        public string? DlCreatedBy { get; set; }

        public DateTime DlLastModifiedDate { get; set; }

        public string? DlLastModifiedBy { get; set; }

        public virtual LocalizableEntry? DlLocalizableEntry { get; set; }

        public virtual ICollection<InsuranceObjectDamageLocation> InsuranceObjectDamageLocations { get; } =
            new List<InsuranceObjectDamageLocation>();

        public virtual ICollection<InvolvedObjectDamageLocation> InvolvedObjectDamageLocations { get; } =
            new List<InvolvedObjectDamageLocation>();
    }
}