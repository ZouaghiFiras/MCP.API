namespace CED.Data.Entities
{
    public class DossierStatusApplicationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DsaId { get; set; }

        public Guid? DsaDossierStatusId { get; set; }

        public Guid? DsaApplicationId { get; set; }

        public DateTime? DsaCreatedDate { get; set; }

        public string? DsaCreatedBy { get; set; }

        public DateTime? DsaLastModifiedDate { get; set; }

        public string? DsaLastModifiedBy { get; set; }
    }
}