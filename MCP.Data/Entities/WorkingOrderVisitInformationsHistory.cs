namespace CED.Data.Entities
{
    public class WorkingOrderVisitInformationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WovId { get; set; }

        public Guid? WovWorkingOrderId { get; set; }

        public Guid? WovVisitInformationId { get; set; }

        public DateTime? WovCreatedDate { get; set; }

        public string? WovCreatedBy { get; set; }

        public DateTime? WovLastModifiedDate { get; set; }

        public string? WovLastModifiedBy { get; set; }
    }
}