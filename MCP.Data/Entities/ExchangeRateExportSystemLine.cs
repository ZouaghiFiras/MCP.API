namespace CED.Data.Entities
{
    public class ExchangeRateExportSystemLine
    {
        public Guid ErelId { get; set; }

        public byte[] ErelTimeStamp { get; set; } = null!;

        public string ErelExchangeRateExportSystemId { get; set; } = null!;

        public Guid ErelExchangeRateCurrencyId { get; set; }

        public DateTime ErelEffectiveDate { get; set; }

        public DateTime? ErelInactiveDate { get; set; }

        public DateTime ErelCreatedDate { get; set; }

        public string? ErelCreatedBy { get; set; }

        public DateTime ErelLastModifiedDate { get; set; }

        public string? ErelLastModifiedBy { get; set; }

        public virtual ExchangeRateCurrency ErelExchangeRateCurrency { get; set; } = null!;

        public virtual ExchangeRateExportSystem ErelExchangeRateExportSystem { get; set; } = null!;
    }
}