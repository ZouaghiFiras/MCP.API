namespace CED.Data.Entities
{
    public class PurchaseOrderConfirmation
    {
        public Guid PocId { get; set; }

        public byte[] PocTimeStamp { get; set; } = null!;

        public Guid PocPurchaseOrderId { get; set; }

        public DateTime PocConfirmationDate { get; set; }

        public bool? PocIsConfirmed { get; set; }

        public Guid PocEmployeeId { get; set; }

        public DateTime PocCreatedDate { get; set; }

        public string? PocCreatedBy { get; set; }

        public DateTime PocLastModifiedDate { get; set; }

        public string? PocLastModifiedBy { get; set; }

        public virtual Employee PocEmployee { get; set; } = null!;

        public virtual PurchaseOrder PocPurchaseOrder { get; set; } = null!;
    }
}