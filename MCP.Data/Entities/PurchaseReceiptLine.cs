namespace CED.Data.Entities
{
    public class PurchaseReceiptLine
    {
        public Guid PrlId { get; set; }

        public byte[] PrlTimeStamp { get; set; } = null!;

        public Guid PrlPurchaseReceiptId { get; set; }

        public int PrlLineNumber { get; set; }

        public double PrlQuantityReceived { get; set; }

        public double PrlQuantityCanceled { get; set; }

        public string? PrlCancellationReason { get; set; }

        public Guid PrlSupplierServiceId { get; set; }

        public string? PrlOrderNumber { get; set; }

        public string? PrlNotes { get; set; }

        public DateTime PrlCreatedDate { get; set; }

        public string? PrlCreatedBy { get; set; }

        public DateTime PrlLastModifiedDate { get; set; }

        public string? PrlLastModifiedBy { get; set; }

        public virtual PurchaseReceipt PrlPurchaseReceipt { get; set; } = null!;

        public virtual SupplierService PrlSupplierService { get; set; } = null!;

        public virtual ICollection<PurchaseOrderReceiptMapping> PurchaseOrderReceiptMappings { get; } =
            new List<PurchaseOrderReceiptMapping>();
    }
}