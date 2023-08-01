namespace CED.Data.Entities
{
    public class CurrencyCountry
    {
        public Guid CucId { get; set; }

        public byte[] CucTimeStamp { get; set; } = null!;

        public string CucCurrencyId { get; set; } = null!;

        public string CucCountryId { get; set; } = null!;

        public decimal CucExchangeAmount { get; set; }

        public bool CucInactive { get; set; }

        public DateTime CucCreatedDate { get; set; }

        public string? CucCreatedBy { get; set; }

        public DateTime CucLastModifiedDate { get; set; }

        public string? CucLastModifiedBy { get; set; }

        public virtual Country CucCountry { get; set; } = null!;

        public virtual Currency CucCurrency { get; set; } = null!;
    }
}