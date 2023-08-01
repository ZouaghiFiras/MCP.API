namespace CED.Data.Entities
{
    public class PurchaseOrderLinesOpenView
    {
        public Guid PurchaseOrderLineId { get; set; }

        public Guid PurchaseOrderId { get; set; }

        public decimal? CreditableNetAmount { get; set; }

        public string? EntrySystem { get; set; }
    }
}