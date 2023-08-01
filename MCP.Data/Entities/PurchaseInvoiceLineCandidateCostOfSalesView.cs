namespace CED.Data.Entities
{
    public class PurchaseInvoiceLineCandidateCostOfSalesView
    {
        public Guid SalesOrderId { get; set; }

        public Guid SalesOrderLineId { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid PurchaseInvoiceLineId { get; set; }

        public decimal SalesOrderLineNetAmount { get; set; }

        public decimal PurchaseInvoiceLineNetAmount { get; set; }

        public decimal PurchaseInvoiceLineGrossAmount { get; set; }

        public decimal PurchaseInvoiceLineTaxAmount { get; set; }

        public decimal PurchaseInvoiceCostOfSalesAmount { get; set; }

        public bool PurchaseInvoiceLineIsContinuousPost { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}