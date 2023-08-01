namespace CED.Data.Entities
{
    public class InvolvedObjectsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? IobId { get; set; }

        public Guid? IobDossierId { get; set; }

        public Guid? IobInsuranceObjectId { get; set; }

        public Guid? IobInvolvedCoverageId { get; set; }

        public int? IobSequenceNumber { get; set; }

        public bool? IobIsActive { get; set; }

        public DateTime? IobCreatedDate { get; set; }

        public string? IobCreatedBy { get; set; }

        public DateTime? IobLastModifiedDate { get; set; }

        public string? IobLastModifiedBy { get; set; }
    }
}