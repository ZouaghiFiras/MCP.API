namespace CED.Data.Entities
{
    public class DossierPartyObjectRelationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DpoId { get; set; }

        public Guid? DpoDossierPartyId { get; set; }

        public Guid? DpoInvolvedObjectId { get; set; }

        public DateTime? DpoCreatedDate { get; set; }

        public string? DpoCreatedBy { get; set; }

        public DateTime? DpoLastModifiedDate { get; set; }

        public string? DpoLastModifiedBy { get; set; }
    }
}