namespace CED.Data.Entities
{
    public class DossierClientHandlerHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DchId { get; set; }

        public Guid? DchDossierId { get; set; }

        public string? DchClientHandlerName { get; set; }

        public string? DchClientHandlerPhone { get; set; }

        public string? DchClientHandlerEmail { get; set; }

        public DateTime? DchStartDate { get; set; }

        public DateTime? DchCreatedDate { get; set; }

        public string? DchCreatedBy { get; set; }

        public DateTime? DchLastModifiedDate { get; set; }

        public string? DchLastModifiedBy { get; set; }
    }
}