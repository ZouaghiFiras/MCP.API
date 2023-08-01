namespace CED.Data.Entities
{
    public class SalesOrderToPurchaseInvoicesView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public string? CurrencyCode { get; set; }

        public string? PaymentCurrencyCode { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal NetAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public double? ExchangeRate { get; set; }

        public string? ExchangeRateProviderName { get; set; }

        public DateTime? ExchangeRateAccountingDate { get; set; }

        public decimal? ConvertedGrossAmount { get; set; }

        public string SupplierName { get; set; } = null!;

        public bool? OnNameOfCed { get; set; }

        public bool? IsPaid { get; set; }

        public DateTime? PaymentDate { get; set; }

        public DateTime? AuthorizationDate { get; set; }

        public string? AuthorizedBy { get; set; }

        public Guid SalesOrderId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}