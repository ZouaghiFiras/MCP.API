namespace CED.Data.Entities
{
    public class SalesInvoiceToPurchaseMapping
    {
        public Guid SitpId { get; set; }

        public byte[] SitpTimeStamp { get; set; } = null!;

        public Guid SitpSalesInvoiceLineId { get; set; }

        public Guid SitpPurchaseInvoiceLineId { get; set; }

        public DateTime SitpCreatedDate { get; set; }

        public string? SitpCreatedBy { get; set; }

        public DateTime SitpLastModifiedDate { get; set; }

        public string? SitpLastModifiedBy { get; set; }

        public virtual PurchaseInvoiceLine SitpPurchaseInvoiceLine { get; set; } = null!;

        public virtual SalesInvoiceLine SitpSalesInvoiceLine { get; set; } = null!;
    }
}