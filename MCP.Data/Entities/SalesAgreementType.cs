namespace CED.Data.Entities
{
    public class SalesAgreementType
    {
        public Guid SgtId { get; set; }

        public byte[] SgtTimeStamp { get; set; } = null!;

        public string SgtCode { get; set; } = null!;

        public string? SgtShortName { get; set; }

        public string SgtLongName { get; set; } = null!;

        public bool SgtInactive { get; set; }

        public Guid? SgtLocalizableEntryId { get; set; }

        public DateTime SgtCreatedDate { get; set; }

        public string? SgtCreatedBy { get; set; }

        public DateTime SgtLastModifiedDate { get; set; }

        public string? SgtLastModifiedBy { get; set; }

        public virtual ICollection<SalesAgreement> SalesAgreements { get; } = new List<SalesAgreement>();

        public virtual LocalizableEntry? SgtLocalizableEntry { get; set; }
    }
}