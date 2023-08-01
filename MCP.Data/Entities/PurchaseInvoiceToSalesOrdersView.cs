namespace CED.Data.Entities
{
    public class PurchaseInvoiceToSalesOrdersView
    {
        public Guid PurchaseInvoiceId { get; set; }

        public string PurchaseInvoiceNumber { get; set; } = null!;

        public DateTime PurchaseInvoiceDate { get; set; }

        public bool PurchaseInvoiceIsCredit { get; set; }

        public Guid? SalesOrderId { get; set; }

        public DateTime? SalesOrderDate { get; set; }

        public decimal? SalesOrderNetAmount { get; set; }

        public decimal? SalesOrderGrossAmount { get; set; }

        public string? SalesOrderNumber { get; set; }

        public string? SalesOrderStatusCode { get; set; }

        public string? SalesOrderStatusName { get; set; }

        public bool? SalesOrderIsCredit { get; set; }

        public bool? SalesOrderIsFee { get; set; }

        public string? SalesOrderCurrencyCode { get; set; }

        public decimal PurchaseInvoiceGrossAmount { get; set; }

        public decimal PurchaseInvoiceNetAmount { get; set; }

        public decimal PurchaseInvoiceTaxAmount { get; set; }

        public Guid? ClientId { get; set; }

        public string ClientName { get; set; } = null!;

        public string? ClientCode { get; set; }

        public DateTime? AuthorizationDate { get; set; }

        public string ApprovalStatus { get; set; } = null!;

        public bool? IsApproved { get; set; }

        public string? Comment { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? AuthorizedBy { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}