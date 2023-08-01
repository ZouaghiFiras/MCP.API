namespace CED.Data.Entities
{
    public class InvolvedCoverageObjectRelationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? IorId { get; set; }

        public Guid? IorInvolvedCoverageId { get; set; }

        public Guid? IorInvolvedObjectId { get; set; }

        public DateTime? IorCreatedDate { get; set; }

        public string? IorCreatedBy { get; set; }

        public DateTime? IorLastModifiedDate { get; set; }

        public string? IorLastModifiedBy { get; set; }
    }
}