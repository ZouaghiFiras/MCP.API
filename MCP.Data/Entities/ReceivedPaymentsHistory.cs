namespace CED.Data.Entities
{
    public class ReceivedPaymentsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? RcpId { get; set; }

        public Guid? RcpRegresId { get; set; }

        public decimal? RcpReceivedValue { get; set; }

        public DateTime? RcpRegistrationDate { get; set; }

        public DateTime? RcpReceivedDate { get; set; }

        public int? RcpStatementNumber { get; set; }

        public int? RcpStatementLine { get; set; }

        public string? RcpRecoveryPaymentId { get; set; }

        public DateTime? RcpCreatedDate { get; set; }

        public string? RcpCreatedBy { get; set; }

        public DateTime? RcpLastModifiedDate { get; set; }

        public string? RcpLastModifiedBy { get; set; }
    }
}