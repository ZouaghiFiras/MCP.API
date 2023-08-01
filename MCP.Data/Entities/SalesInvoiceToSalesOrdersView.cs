namespace CED.Data.Entities
{
    public class SalesInvoiceToSalesOrdersView
    {
        public Guid SalesOrderId { get; set; }

        public string SalesOrderNumber { get; set; } = null!;

        public Guid SalesInvoiceId { get; set; }

        public DateTime SalesInvoiceDate { get; set; }

        public decimal SalesInvoiceNetAmount { get; set; }

        public string SalesInvoiceNumber { get; set; } = null!;

        public string SalesInvoiceDebtorNumber { get; set; } = null!;

        public string SalesInvoiceDebtorName { get; set; } = null!;

        public Guid? SalesInvoiceStatusId { get; set; }

        public string? SalesInvoiceStatusCode { get; set; }

        public string? SalesInvoiceStatusName { get; set; }

        public DateTime? SalesInvoicePaymentDate { get; set; }

        public bool SalesInvoiceIsCredit { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal NetAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public Guid ClientId { get; set; }

        public string ClientName { get; set; } = null!;

        public string ClientCode { get; set; } = null!;

        public Guid? DeprecatedSalesOrderId { get; set; }

        public string? DeprecatedSalesOrderNumber { get; set; }

        public Guid? DeprecatedSalesOrderClientId { get; set; }

        public string? DeprecatedSalesOrderClientCode { get; set; }

        public string DeprecatedSalesOrderClientName { get; set; } = null!;

        public string? SalesOrderCreditType { get; set; }

        public DateTime SalesOrderDate { get; set; }

        public bool SalesOrderIsCredit { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}