namespace CED.Data.Entities
{
    public class ValuationPrinciple
    {
        public Guid VpId { get; set; }

        public byte[] VpTimeStamp { get; set; } = null!;

        public string VpCode { get; set; } = null!;

        public string? VpShortName { get; set; }

        public string VpLongName { get; set; } = null!;

        public bool VpInactive { get; set; }

        public Guid? VpLocalizableEntryId { get; set; }

        public DateTime VpCreatedDate { get; set; }

        public string? VpCreatedBy { get; set; }

        public DateTime VpLastModifiedDate { get; set; }

        public string? VpLastModifiedBy { get; set; }

        public virtual LocalizableEntry? VpLocalizableEntry { get; set; }
    }
}