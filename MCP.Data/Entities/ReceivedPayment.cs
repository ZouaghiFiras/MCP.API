namespace CED.Data.Entities
{
    public class ReceivedPayment
    {
        public Guid RcpId { get; set; }

        public byte[] RcpTimeStamp { get; set; } = null!;

        public Guid RcpRegresId { get; set; }

        public decimal RcpReceivedValue { get; set; }

        public DateTime RcpRegistrationDate { get; set; }

        public DateTime? RcpReceivedDate { get; set; }

        public int? RcpStatementNumber { get; set; }

        public int? RcpStatementLine { get; set; }

        public string? RcpRecoveryPaymentId { get; set; }

        public DateTime RcpCreatedDate { get; set; }

        public string? RcpCreatedBy { get; set; }

        public DateTime RcpLastModifiedDate { get; set; }

        public string? RcpLastModifiedBy { get; set; }

        public virtual Regre RcpRegres { get; set; } = null!;
    }
}