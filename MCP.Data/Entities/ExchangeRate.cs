namespace CED.Data.Entities
{
    public class ExchangeRate
    {
        public Guid ExrId { get; set; }

        public byte[] ExrTimeStamp { get; set; } = null!;

        public DateTime ExrEffectiveDate { get; set; }

        public DateTime ExrUntilDate { get; set; }

        public DateTime ExrAccountingDate { get; set; }

        public decimal ExrExchangeAmount { get; set; }

        public string ExrFromCurrencyIso3 { get; set; } = null!;

        public string ExrToCurrencyIso3 { get; set; } = null!;

        public double? ExrAskRate { get; set; }

        public double ExrMidRate { get; set; }

        public double? ExrBidRate { get; set; }

        public Guid ExrExchangeRateProviderId { get; set; }

        public DateTime ExrRetrievalDate { get; set; }

        public DateTime ExrCreatedDate { get; set; }

        public string? ExrCreatedBy { get; set; }

        public DateTime ExrLastModifiedDate { get; set; }

        public string? ExrLastModifiedBy { get; set; }

        public virtual ICollection<AssistancePlanCoverage> AssistancePlanCoverages { get; } =
            new List<AssistancePlanCoverage>();

        public virtual ICollection<AssistancePlanLine> AssistancePlanLines { get; } = new List<AssistancePlanLine>();

        public virtual ICollection<ExchangeRateExport> ExchangeRateExports { get; } = new List<ExchangeRateExport>();

        public virtual ExchangeRateProvider ExrExchangeRateProvider { get; set; } = null!;

        public virtual Currency ExrFromCurrencyIso3Navigation { get; set; } = null!;

        public virtual Currency ExrToCurrencyIso3Navigation { get; set; } = null!;

        public virtual ICollection<JournalEntry> JournalEntries { get; } = new List<JournalEntry>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoicePivExchangeRateNavigations { get; } =
            new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoicePivForeignToPaymentExchangeRateNavigations { get; } =
            new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoicePivPaymentExchangeRateNavigations { get; } =
            new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoicePivPaymentToLeadExchangeRateNavigations { get; } =
            new List<PurchaseInvoice>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual ICollection<SalesOrder> SalesOrders { get; } = new List<SalesOrder>();
    }
}