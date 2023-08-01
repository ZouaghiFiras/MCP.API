namespace CED.Data.Entities
{
    public class DossierHandlersHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DohId { get; set; }

        public Guid? DohDossierId { get; set; }

        public Guid? DohEmployeeId { get; set; }

        public DateTime? DohStartDate { get; set; }

        public DateTime? DohCreatedDate { get; set; }

        public string? DohCreatedBy { get; set; }

        public DateTime? DohLastModifiedDate { get; set; }

        public string? DohLastModifiedBy { get; set; }
    }
}