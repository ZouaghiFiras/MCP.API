namespace CED.Data.Entities
{
    public class Currency
    {
        public string CrrId { get; set; } = null!;

        public byte[] CrrTimeStamp { get; set; } = null!;

        public string CrrName { get; set; } = null!;

        public bool CrrInactive { get; set; }

        public decimal CrrExchangeAmount { get; set; }

        public Guid? CrrLocalizableEntryId { get; set; }

        public DateTime CrrCreatedDate { get; set; }

        public string? CrrCreatedBy { get; set; }

        public DateTime CrrLastModifiedDate { get; set; }

        public string? CrrLastModifiedBy { get; set; }

        public virtual LocalizableEntry? CrrLocalizableEntry { get; set; }

        public virtual ICollection<CurrencyCountry> CurrencyCountries { get; } = new List<CurrencyCountry>();

        public virtual ICollection<ExchangeRateCurrency> ExchangeRateCurrencyExcFromCurrencyIso3Navigations { get; } =
            new List<ExchangeRateCurrency>();

        public virtual ICollection<ExchangeRateCurrency> ExchangeRateCurrencyExcToCurrencyIso3Navigations { get; } =
            new List<ExchangeRateCurrency>();

        public virtual ICollection<ExchangeRate> ExchangeRateExrFromCurrencyIso3Navigations { get; } =
            new List<ExchangeRate>();

        public virtual ICollection<ExchangeRate> ExchangeRateExrToCurrencyIso3Navigations { get; } =
            new List<ExchangeRate>();
    }
}