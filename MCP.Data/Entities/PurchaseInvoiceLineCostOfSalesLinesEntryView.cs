namespace CED.Data.Entities
{
    public class PurchaseInvoiceLineCostOfSalesLinesEntryView
    {
        public Guid PurchaseInvoiceLineId { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public double Quantity { get; set; }

        public decimal PurchaseInvoiceLineNetAmount { get; set; }

        public bool CostOfSaleIsCredit { get; set; }

        public decimal CostOfSaleNetAmount { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}