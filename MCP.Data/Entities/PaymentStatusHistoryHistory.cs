namespace CED.Data.Entities
{
    public class PaymentStatusHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? PshId { get; set; }

        public Guid? PshPaymentId { get; set; }

        public Guid? PshPaymentStatusId { get; set; }

        public DateTime? PshStartDate { get; set; }

        public DateTime? PshCreatedDate { get; set; }

        public string? PshCreatedBy { get; set; }

        public DateTime? PshLastModifiedDate { get; set; }

        public string? PshLastModifiedBy { get; set; }
    }
}