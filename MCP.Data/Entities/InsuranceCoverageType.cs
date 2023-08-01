namespace CED.Data.Entities
{
    public class InsuranceCoverageType
    {
        public Guid IctId { get; set; }

        public byte[] IctTimeStamp { get; set; } = null!;

        public string IctCode { get; set; } = null!;

        public string? IctShortName { get; set; }

        public string IctLongName { get; set; } = null!;

        public bool IctInactive { get; set; }

        public Guid? IctLocalizableEntryId { get; set; }

        public DateTime IctCreatedDate { get; set; }

        public string? IctCreatedBy { get; set; }

        public DateTime IctLastModifiedDate { get; set; }

        public string? IctLastModifiedBy { get; set; }

        public virtual LocalizableEntry? IctLocalizableEntry { get; set; }

        public virtual ICollection<InsuranceCoverage> InsuranceCoverages { get; } = new List<InsuranceCoverage>();
    }
}