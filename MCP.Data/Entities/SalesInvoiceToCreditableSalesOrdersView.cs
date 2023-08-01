namespace CED.Data.Entities
{
    public class SalesInvoiceToCreditableSalesOrdersView
    {
        public Guid SalesInvoiceId { get; set; }

        public DateTime SalesInvoiceDate { get; set; }

        public string SalesInvoiceNumber { get; set; } = null!;

        public Guid SalesOrderId { get; set; }

        public string SalesOrderNumber { get; set; } = null!;
    }
}