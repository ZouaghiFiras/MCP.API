namespace CED.Data.Entities
{
    public class PurchaseInvoiceLineExpectedCostOfSalesView
    {
        public Guid PurchaseInvoiceLineId { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid? ServiceId { get; set; }

        public decimal AssistancePlanLineCostOfSalesAmount { get; set; }

        public decimal AssistancePlanLineAmount { get; set; }

        public decimal PurchaseInvoiceLineNetAmount { get; set; }

        public decimal? ExpectedCostOfSalesAmount { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}