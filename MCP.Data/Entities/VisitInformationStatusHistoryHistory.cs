namespace CED.Data.Entities
{
    public class VisitInformationStatusHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? VishId { get; set; }

        public Guid? VishVisitInformationId { get; set; }

        public Guid? VishVisitInformationStatusId { get; set; }

        public Guid? VishEmployeeId { get; set; }

        public DateTime? VishStartDate { get; set; }

        public string? VishStatusChangeReason { get; set; }

        public DateTime? VishCreatedDate { get; set; }

        public string? VishCreatedBy { get; set; }

        public DateTime? VishLastModifiedDate { get; set; }

        public string? VishLastModifiedBy { get; set; }
    }
}