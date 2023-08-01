namespace CED.Data.Entities
{
    public class PurchaseInvoiceStatusHistory
    {
        public Guid PishId { get; set; }

        public byte[] PishTimeStamp { get; set; } = null!;

        public Guid PishPurchaseInvoiceId { get; set; }

        public Guid PishPurchaseInvoiceStatusId { get; set; }

        public Guid? PishEmployeeId { get; set; }

        public DateTime PishStartDate { get; set; }

        public string? PishStatusChangeReason { get; set; }

        public DateTime PishCreatedDate { get; set; }

        public string? PishCreatedBy { get; set; }

        public DateTime PishLastModifiedDate { get; set; }

        public string? PishLastModifiedBy { get; set; }

        public virtual Employee? PishEmployee { get; set; }

        public virtual PurchaseInvoice PishPurchaseInvoice { get; set; } = null!;

        public virtual PurchaseInvoiceStatus PishPurchaseInvoiceStatus { get; set; } = null!;
    }
}