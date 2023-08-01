namespace CED.Data.Entities
{
    public class ExchangeConversionRatesView
    {
        public Guid Id { get; set; }

        public DateTime AccountingDate { get; set; }

        public string ProviderCode { get; set; } = null!;

        public string ProviderName { get; set; } = null!;

        public decimal ExchangeAmount { get; set; }

        public string FromCurrency { get; set; } = null!;

        public string ToCurrency { get; set; } = null!;

        public double? BidRate { get; set; }

        public double MidRate { get; set; }

        public double? AskRate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}