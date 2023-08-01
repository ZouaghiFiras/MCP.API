namespace CED.Data.Entities
{
    public class PurchaseOrderReceiptMapping
    {
        public Guid PomId { get; set; }

        public byte[] PomTimeStamp { get; set; } = null!;

        public Guid PomPurchaseOrderLineId { get; set; }

        public Guid PomPurchaseReceiptLineId { get; set; }

        public DateTime PomMappingDate { get; set; }

        public DateTime PomCreatedDate { get; set; }

        public string? PomCreatedBy { get; set; }

        public DateTime PomLastModifiedDate { get; set; }

        public string? PomLastModifiedBy { get; set; }

        public virtual PurchaseOrderLine PomPurchaseOrderLine { get; set; } = null!;

        public virtual PurchaseReceiptLine PomPurchaseReceiptLine { get; set; } = null!;
    }
}