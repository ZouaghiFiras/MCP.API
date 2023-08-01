namespace CED.Data.Entities
{
    public class InvolvedObjectDamageLocationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? IolId { get; set; }

        public Guid? IolInvolvedObjectId { get; set; }

        public Guid? IolDamageLocationId { get; set; }

        public int? IolSequenceNumber { get; set; }

        public bool? IolIsActive { get; set; }

        public DateTime? IolCreatedDate { get; set; }

        public string? IolCreatedBy { get; set; }

        public DateTime? IolLastModifiedDate { get; set; }

        public string? IolLastModifiedBy { get; set; }
    }
}