namespace CED.Data.Entities
{
    public class DossierPrioritiesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DopId { get; set; }

        public string? DopCode { get; set; }

        public string? DopShortName { get; set; }

        public string? DopLongName { get; set; }

        public bool? DopInactive { get; set; }

        public DateTime? DopCreatedDate { get; set; }

        public string? DopCreatedBy { get; set; }

        public DateTime? DopLastModifiedDate { get; set; }

        public string? DopLastModifiedBy { get; set; }
    }
}