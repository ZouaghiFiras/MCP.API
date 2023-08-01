namespace CED.Data.Entities
{
    public class DossierAssignmentClosingHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? AchId { get; set; }

        public Guid? AchDossierAssignmentId { get; set; }

        public DateTime? AchClosingDate { get; set; }

        public bool? AchOperationalClosing { get; set; }

        public bool? AchFinancialClosing { get; set; }

        public DateTime? AchCreatedDate { get; set; }

        public string? AchCreatedBy { get; set; }

        public DateTime? AchLastModifiedDate { get; set; }

        public string? AchLastModifiedBy { get; set; }
    }
}