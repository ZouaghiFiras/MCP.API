namespace CED.Data.Entities
{
    public class RecoveryPaymentStatusHistory
    {
        public Guid RshId { get; set; }

        public byte[] RshTimeStamp { get; set; } = null!;

        public Guid RshRecoveryPaymentId { get; set; }

        public Guid RshRecoveryPaymentStatusId { get; set; }

        public DateTime RshStartDate { get; set; }

        public DateTime RshCreatedDate { get; set; }

        public string? RshCreatedBy { get; set; }

        public DateTime RshLastModifiedDate { get; set; }

        public string? RshLastModifiedBy { get; set; }

        public virtual RecoveryPayment RshRecoveryPayment { get; set; } = null!;

        public virtual RecoveryPaymentStatus RshRecoveryPaymentStatus { get; set; } = null!;
    }
}