namespace CED.Data.Entities
{
    public class PurchaseInvoiceLineCostOfSalesAmountsView
    {
        public Guid PurchaseInvoiceId { get; set; }

        public Guid PurchaseInvoiceLineId { get; set; }

        public Guid? ServiceId { get; set; }

        public decimal CurrentCostOfSalesAmount { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}