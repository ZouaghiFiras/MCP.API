namespace CED.Data.Entities
{
    public class ExchangeRateCurrency
    {
        public Guid ExcId { get; set; }

        public byte[] ExcTimeStamp { get; set; } = null!;

        public string ExcFromCurrencyIso3 { get; set; } = null!;

        public string ExcToCurrencyIso3 { get; set; } = null!;

        public DateTime ExcEffectiveDate { get; set; }

        public Guid ExcExchangeRateProviderId { get; set; }

        public DateTime? ExcInactiveDate { get; set; }

        public DateTime ExcCreatedDate { get; set; }

        public string? ExcCreatedBy { get; set; }

        public DateTime ExcLastModifiedDate { get; set; }

        public string? ExcLastModifiedBy { get; set; }

        public virtual ExchangeRateProvider ExcExchangeRateProvider { get; set; } = null!;

        public virtual Currency ExcFromCurrencyIso3Navigation { get; set; } = null!;

        public virtual Currency ExcToCurrencyIso3Navigation { get; set; } = null!;

        public virtual ICollection<ExchangeRateExportSystemLine> ExchangeRateExportSystemLines { get; } =
            new List<ExchangeRateExportSystemLine>();
    }
}