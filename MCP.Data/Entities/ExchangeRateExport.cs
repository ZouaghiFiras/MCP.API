namespace CED.Data.Entities
{
    public class ExchangeRateExport
    {
        public Guid EreId { get; set; }

        public byte[] EreTimeStamp { get; set; } = null!;

        public Guid EreExchangeRateId { get; set; }

        public DateTime EreExportDate { get; set; }

        public string EreExchangeRateExportSystemId { get; set; } = null!;

        public DateTime EreCreatedDate { get; set; }

        public string? EreCreatedBy { get; set; }

        public DateTime EreLastModifiedDate { get; set; }

        public string? EreLastModifiedBy { get; set; }

        public virtual ExchangeRate EreExchangeRate { get; set; } = null!;

        public virtual ExchangeRateExportSystem EreExchangeRateExportSystem { get; set; } = null!;
    }
}