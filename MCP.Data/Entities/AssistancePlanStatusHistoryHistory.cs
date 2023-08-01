namespace CED.Data.Entities
{
    public class AssistancePlanStatusHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? AphId { get; set; }

        public Guid? AphAssistancePlanId { get; set; }

        public Guid? AphAssistancePlanStatusId { get; set; }

        public Guid? AphEmployeeId { get; set; }

        public DateTime? AphStartDate { get; set; }

        public DateTime? AphCreatedDate { get; set; }

        public string? AphCreatedBy { get; set; }

        public DateTime? AphLastModifiedDate { get; set; }

        public string? AphLastModifiedBy { get; set; }

        public string? AphStatusChangeReason { get; set; }
    }
}