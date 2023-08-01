namespace CED.Data.Entities
{
    public class PaymentStatusesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? PstId { get; set; }

        public string? PstCode { get; set; }

        public string? PstShortName { get; set; }

        public string? PstLongName { get; set; }

        public bool? PstInactive { get; set; }

        public Guid? PstLocalizableEntryId { get; set; }

        public DateTime? PstCreatedDate { get; set; }

        public string? PstCreatedBy { get; set; }

        public DateTime? PstLastModifiedDate { get; set; }

        public string? PstLastModifiedBy { get; set; }
    }
}