namespace CED.Data.Entities
{
    public class SalesPaymentStatusHistory
    {
        public Guid SphId { get; set; }

        public byte[] SphTimeStamp { get; set; } = null!;

        public Guid SphSalesPaymentId { get; set; }

        public Guid SphSalesPaymentStatusId { get; set; }

        public DateTime SphStartDate { get; set; }

        public DateTime SphCreatedDate { get; set; }

        public string? SphCreatedBy { get; set; }

        public DateTime SphLastModifiedDate { get; set; }

        public string? SphLastModifiedBy { get; set; }

        public virtual SalesPayment SphSalesPayment { get; set; } = null!;

        public virtual SalesPaymentStatus SphSalesPaymentStatus { get; set; } = null!;
    }
}