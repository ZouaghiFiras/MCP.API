namespace CED.Data.Entities
{
    public class CostAgreementType
    {
        public Guid CgtId { get; set; }

        public byte[] CgtTimeStamp { get; set; } = null!;

        public string CgtCode { get; set; } = null!;

        public string? CgtShortName { get; set; }

        public string CgtLongName { get; set; } = null!;

        public bool CgtInactive { get; set; }

        public Guid? CgtLocalizableEntryId { get; set; }

        public DateTime CgtCreatedDate { get; set; }

        public string? CgtCreatedBy { get; set; }

        public DateTime CgtLastModifiedDate { get; set; }

        public string? CgtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? CgtLocalizableEntry { get; set; }

        public virtual ICollection<CostAgreement> CostAgreements { get; } = new List<CostAgreement>();
    }
}