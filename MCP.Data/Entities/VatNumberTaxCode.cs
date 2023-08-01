namespace CED.Data.Entities
{
    public class VatNumberTaxCode
    {
        public Guid VtcId { get; set; }

        public byte[] VtcTimeStamp { get; set; } = null!;

        public bool VtcIsValidVatNumer { get; set; }

        public bool VtcIsEuropeanVatNumber { get; set; }

        public string VtcTaxCodeId { get; set; } = null!;

        public bool VtcInactive { get; set; }

        public Guid? VtcLocalizableEntryId { get; set; }

        public DateTime VtcCreatedDate { get; set; }

        public string? VtcCreatedBy { get; set; }

        public DateTime VtcLastModifiedDate { get; set; }

        public string? VtcLastModifiedBy { get; set; }

        public virtual LocalizableEntry? VtcLocalizableEntry { get; set; }
    }
}