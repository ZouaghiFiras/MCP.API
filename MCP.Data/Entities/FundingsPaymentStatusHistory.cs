namespace CED.Data.Entities
{
    public class FundingsPaymentStatusHistory
    {
        public Guid FphId { get; set; }

        public byte[] FphTimeStamp { get; set; } = null!;

        public Guid FphFundingsPaymentId { get; set; }

        public Guid FphFundingsPaymentStatusId { get; set; }

        public DateTime FphStartDate { get; set; }

        public DateTime FphCreatedDate { get; set; }

        public string? FphCreatedBy { get; set; }

        public DateTime FphLastModifiedDate { get; set; }

        public string? FphLastModifiedBy { get; set; }

        public virtual FundingsPayment FphFundingsPayment { get; set; } = null!;

        public virtual FundingsPaymentStatus FphFundingsPaymentStatus { get; set; } = null!;
    }
}