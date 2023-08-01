namespace CED.Data.Entities
{
    public class ExchangeRatesExactView
    {
        public Guid Id { get; set; }

        public DateTime EffectiveDate { get; set; }

        public DateTime UntilDate { get; set; }

        public DateTime AccountingDate { get; set; }

        public decimal ExchangeAmount { get; set; }

        public string FromCurrencyIso3 { get; set; } = null!;

        public string ToCurrencyIso3 { get; set; } = null!;

        public double? AskRate { get; set; }

        public double MidRate { get; set; }

        public double? BidRate { get; set; }

        public string? ProviderName { get; set; }

        public string ExportSystemId { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}