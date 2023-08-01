namespace CED.Data.Entities
{
    public class ServiceTaxRate
    {
        public Guid StrId { get; set; }

        public byte[] StrTimeStamp { get; set; } = null!;

        public Guid StrLegalEntityId { get; set; }

        public Guid StrServiceId { get; set; }

        public string StrCountryIso2Code { get; set; } = null!;

        public string StrTaxCategoryId { get; set; } = null!;

        public DateTime StrEffectiveDate { get; set; }

        public DateTime? StrTerminationDate { get; set; }

        public DateTime StrCreatedDate { get; set; }

        public string? StrCreatedBy { get; set; }

        public DateTime StrLastModifiedDate { get; set; }

        public string? StrLastModifiedBy { get; set; }

        public virtual Country StrCountryIso2CodeNavigation { get; set; } = null!;

        public virtual LegalEntity StrLegalEntity { get; set; } = null!;

        public virtual Service StrService { get; set; } = null!;

        public virtual TaxCategory StrTaxCategory { get; set; } = null!;
    }
}