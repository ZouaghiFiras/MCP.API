namespace CED.Data.Entities
{
    public class PurchasePaymentStatusHistory
    {
        public Guid PphId { get; set; }

        public byte[] PphTimeStamp { get; set; } = null!;

        public Guid PphPurchasePaymentId { get; set; }

        public Guid PphPurchasePaymentStatusId { get; set; }

        public Guid? PphEmployeeId { get; set; }

        public DateTime PphStartDate { get; set; }

        public DateTime PphCreatedDate { get; set; }

        public string? PphCreatedBy { get; set; }

        public DateTime PphLastModifiedDate { get; set; }

        public string? PphLastModifiedBy { get; set; }

        public virtual Employee? PphEmployee { get; set; }

        public virtual PurchasePayment PphPurchasePayment { get; set; } = null!;

        public virtual PurchasePaymentStatus PphPurchasePaymentStatus { get; set; } = null!;
    }
}