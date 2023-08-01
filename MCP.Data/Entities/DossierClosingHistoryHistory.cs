namespace CED.Data.Entities
{
    public class DossierClosingHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DchId { get; set; }

        public Guid? DchDossierId { get; set; }

        public DateTime? DchClosingDate { get; set; }

        public bool? DchOperationalClosing { get; set; }

        public bool? DchFinancialClosing { get; set; }

        public DateTime? DchCreatedDate { get; set; }

        public string? DchCreatedBy { get; set; }

        public DateTime? DchLastModifiedDate { get; set; }

        public string? DchLastModifiedBy { get; set; }

        public bool? DchCancelled { get; set; }

        public string? DchClosingReason { get; set; }
    }
}