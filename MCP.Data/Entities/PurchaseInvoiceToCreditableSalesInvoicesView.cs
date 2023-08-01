namespace CED.Data.Entities
{
    public class PurchaseInvoiceToCreditableSalesInvoicesView
    {
        public Guid PurchaseInvoiceId { get; set; }

        public DateTime PurchaseInvoiceDate { get; set; }

        public string PurchaseInvoiceNumber { get; set; } = null!;

        public Guid SalesInvoiceId { get; set; }

        public string SalesInvoiceNumber { get; set; } = null!;
    }
}