namespace CED.Data.Entities
{
    public class ExchangeRateProvider
    {
        public Guid ErpId { get; set; }

        public byte[] ErpTimeStamp { get; set; } = null!;

        public string ErpCode { get; set; } = null!;

        public string? ErpShortName { get; set; }

        public string ErpLongName { get; set; } = null!;

        public string? ErpResource { get; set; }

        public DateTime ErpCreatedDate { get; set; }

        public string? ErpCreatedBy { get; set; }

        public DateTime ErpLastModifiedDate { get; set; }

        public string? ErpLastModifiedBy { get; set; }

        public virtual ICollection<CostFeeSettlement> CostFeeSettlements { get; } = new List<CostFeeSettlement>();

        public virtual ICollection<ExchangeRateCurrency> ExchangeRateCurrencies { get; } =
            new List<ExchangeRateCurrency>();

        public virtual ICollection<ExchangeRate> ExchangeRates { get; } = new List<ExchangeRate>();

        public virtual ICollection<FeeSettlement> FeeSettlements { get; } = new List<FeeSettlement>();
    }
}