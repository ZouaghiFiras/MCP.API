namespace CED.Data.Entities
{
    public class ExchangePendingRetrievalView
    {
        public string ErpCode { get; set; } = null!;

        public string? ErpShortName { get; set; }

        public string ExcFromCurrencyIso3 { get; set; } = null!;

        public string ExcToCurrencyIso3 { get; set; } = null!;

        public DateTime? LastAccountingDate { get; set; }

        public DateTime? AccountingDate { get; set; }
    }
}