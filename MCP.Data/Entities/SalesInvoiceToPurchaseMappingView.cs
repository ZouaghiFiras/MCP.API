namespace CED.Data.Entities
{
    public class SalesInvoiceToPurchaseMappingView
    {
        public Guid? PurchaseInvoiceLineId { get; set; }

        public string? PurchaseInvoiceNumber { get; set; }

        public Guid? PurchaseInvoiceId { get; set; }

        public DateTime? PurchaseInvoiceDate { get; set; }

        public Guid? SupplierId { get; set; }

        public string? SupplierCode { get; set; }

        public string? SupplierName { get; set; }

        public Guid? CreditorId { get; set; }

        public string? CreditorNumber { get; set; }

        public string? CreditorName { get; set; }

        public string SalesOrderNumber { get; set; } = null!;

        public Guid SalesOrderId { get; set; }

        public Guid SalesOrderLineId { get; set; }

        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public Guid SalesInvoiceId { get; set; }

        public Guid SalesInvoiceLineId { get; set; }

        public decimal SalesInvoiceLineNetAmount { get; set; }

        public decimal SalesInvoiceLineGrossAmount { get; set; }

        public decimal SalesInvoiceLineTaxAmount { get; set; }

        public bool SalesInvoiceLineIsCredit { get; set; }

        public decimal SalesOrderLineNetAmount { get; set; }

        public decimal SalesOrderLineGrossAmount { get; set; }

        public decimal SalesOrderLineTaxAmount { get; set; }

        public decimal? PurchaseInvoiceLineNetAmount { get; set; }

        public decimal? PurchaseInvoiceLineGrossAmount { get; set; }

        public decimal? PurchaseInvoiceLineTaxAmount { get; set; }

        public decimal SalesOrderNetAmount { get; set; }

        public decimal SalesOrderGrossAmount { get; set; }

        public decimal SalesOrderTaxAmount { get; set; }

        public Guid ServiceId { get; set; }

        public string ServiceCode { get; set; } = null!;

        public string ServiceName { get; set; } = null!;

        public Guid ProductId { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public decimal? CostOfSalesAmount { get; set; }
    }
}