namespace CED.Data.Entities
{
    public class FeeAgreementType
    {
        public Guid AgtId { get; set; }

        public byte[] AgtTimeStamp { get; set; } = null!;

        public string AgtCode { get; set; } = null!;

        public string? AgtShortName { get; set; }

        public string AgtLongName { get; set; } = null!;

        public bool AgtInactive { get; set; }

        public Guid? AgtLocalizableEntryId { get; set; }

        public DateTime AgtCreatedDate { get; set; }

        public string? AgtCreatedBy { get; set; }

        public DateTime AgtLastModifiedDate { get; set; }

        public string? AgtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? AgtLocalizableEntry { get; set; }

        public virtual ICollection<FeeAgreement> FeeAgreements { get; } = new List<FeeAgreement>();
    }
}