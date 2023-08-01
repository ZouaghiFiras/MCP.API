namespace CED.Data.Entities
{
    public class Country
    {
        public string CntId { get; set; } = null!;

        public byte[] CntTimeStamp { get; set; } = null!;

        public string CntIso3Code { get; set; } = null!;

        public string CntName { get; set; } = null!;

        public bool CntInactive { get; set; }

        public Guid? CntLocalizableEntryId { get; set; }

        public DateTime CntCreatedDate { get; set; }

        public string? CntCreatedBy { get; set; }

        public DateTime CntLastModifiedDate { get; set; }

        public string? CntLastModifiedBy { get; set; }

        public virtual LocalizableEntry? CntLocalizableEntry { get; set; }

        public virtual ICollection<CurrencyCountry> CurrencyCountries { get; } = new List<CurrencyCountry>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();

        public virtual EuropeanUnionCountry? EuropeanUnionCountry { get; set; }

        public virtual ICollection<GreenCardOfficeCountry> GreenCardOfficeCountries { get; } =
            new List<GreenCardOfficeCountry>();

        public virtual IbanCountry? IbanCountry { get; set; }

        public virtual ICollection<LocationTaxCode> LocationTaxCodes { get; } = new List<LocationTaxCode>();

        public virtual ICollection<LocationTaxRate> LocationTaxRates { get; } = new List<LocationTaxRate>();

        public virtual SepaCountry? SepaCountry { get; set; }

        public virtual ICollection<ServiceTaxRate> ServiceTaxRates { get; } = new List<ServiceTaxRate>();
    }
}