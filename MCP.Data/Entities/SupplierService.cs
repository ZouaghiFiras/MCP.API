namespace CED.Data.Entities
{
    public class SupplierService
    {
        public Guid SsiId { get; set; }

        public byte[] SsiTimeStamp { get; set; } = null!;

        public Guid SsiSupplierId { get; set; }

        public Guid SsiServiceId { get; set; }

        public DateTime SsiEffectiveDate { get; set; }

        public DateTime? SsiEndDate { get; set; }

        public DateTime SsiCreatedDate { get; set; }

        public string? SsiCreatedBy { get; set; }

        public DateTime SsiLastModifiedDate { get; set; }

        public string? SsiLastModifiedBy { get; set; }

        public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

        public virtual ICollection<PurchaseReceiptLine> PurchaseReceiptLines { get; } = new List<PurchaseReceiptLine>();

        public virtual Service SsiService { get; set; } = null!;

        public virtual Supplier SsiSupplier { get; set; } = null!;
    }
}