namespace CED.Data.Entities
{
    public class PaymentStatusHistory
    {
        public Guid PshId { get; set; }

        public byte[] PshTimeStamp { get; set; } = null!;

        public Guid PshPaymentId { get; set; }

        public Guid PshPaymentStatusId { get; set; }

        public DateTime PshStartDate { get; set; }

        public DateTime PshCreatedDate { get; set; }

        public string? PshCreatedBy { get; set; }

        public DateTime PshLastModifiedDate { get; set; }

        public string? PshLastModifiedBy { get; set; }

        public virtual Payment PshPayment { get; set; } = null!;

        public virtual PaymentStatus PshPaymentStatus { get; set; } = null!;
    }
}