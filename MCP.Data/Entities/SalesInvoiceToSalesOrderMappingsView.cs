namespace CED.Data.Entities
{
    public class SalesInvoiceToSalesOrderMappingsView
    {
        public Guid Id { get; set; }

        public Guid SalesInvoiceId { get; set; }

        public Guid ClientId { get; set; }

        public Guid SalesOrderId { get; set; }
    }
}