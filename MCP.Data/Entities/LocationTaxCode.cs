namespace CED.Data.Entities
{
    public class LocationTaxCode
    {
        public Guid TxlId { get; set; }

        public byte[] TxlTimeStamp { get; set; } = null!;

        public Guid? TxlLegalEntityId { get; set; }

        public string? TxlAbbreviation { get; set; }

        public string TxlDescription { get; set; } = null!;

        public string TxlCountryIso2Code { get; set; } = null!;

        public string? TxlCity { get; set; }

        public short TxlTaxTypeId { get; set; }

        public string? TxlTaxCodeId { get; set; }

        public DateTime TxlValidFrom { get; set; }

        public DateTime? TxlValidUntil { get; set; }

        public DateTime TxlCreatedDate { get; set; }

        public string? TxlCreatedBy { get; set; }

        public DateTime TxlLastModifiedDate { get; set; }

        public string? TxlLastModifiedBy { get; set; }

        public virtual Country TxlCountryIso2CodeNavigation { get; set; } = null!;

        public virtual LegalEntity? TxlLegalEntity { get; set; }
    }
}