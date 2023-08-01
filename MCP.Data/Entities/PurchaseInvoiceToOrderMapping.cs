namespace CED.Data.Entities
{
    public class PurchaseInvoiceToOrderMapping
    {
        public Guid PitoId { get; set; }

        public byte[] PitoTimeStamp { get; set; } = null!;

        public Guid PitoPurchaseInvoiceLineId { get; set; }

        public Guid PitoPurchaseOrderLineId { get; set; }

        public bool PitoInactive { get; set; }

        public DateTime PitoCreatedDate { get; set; }

        public string? PitoCreatedBy { get; set; }

        public DateTime PitoLastModifiedDate { get; set; }

        public string? PitoLastModifiedBy { get; set; }

        public virtual PurchaseInvoiceLine PitoPurchaseInvoiceLine { get; set; } = null!;

        public virtual PurchaseOrderLine PitoPurchaseOrderLine { get; set; } = null!;
    }
}