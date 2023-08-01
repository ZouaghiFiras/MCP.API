namespace CED.Data.Entities
{
    public class PurchaseInvoiceToCreditableSalesOrdersView
    {
        public Guid PurchaseInvoiceId { get; set; }

        public DateTime PurchaseInvoiceDate { get; set; }

        public string PurchaseInvoiceNumber { get; set; } = null!;

        public Guid SalesOrderId { get; set; }

        public string SalesOrderNumber { get; set; } = null!;
    }
}