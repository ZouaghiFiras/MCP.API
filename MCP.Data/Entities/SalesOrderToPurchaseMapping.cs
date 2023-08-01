namespace CED.Data.Entities
{
    public class SalesOrderToPurchaseMapping
    {
        public Guid SotpId { get; set; }

        public byte[] SotpTimeStamp { get; set; } = null!;

        public Guid SotpSalesOrderLineId { get; set; }

        public Guid SotpPurchaseInvoiceLineId { get; set; }

        public DateTime SotpCreatedDate { get; set; }

        public string? SotpCreatedBy { get; set; }

        public DateTime SotpLastModifiedDate { get; set; }

        public string? SotpLastModifiedBy { get; set; }

        public virtual PurchaseInvoiceLine SotpPurchaseInvoiceLine { get; set; } = null!;

        public virtual SalesOrderLine SotpSalesOrderLine { get; set; } = null!;
    }
}