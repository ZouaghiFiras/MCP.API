namespace CED.Data.Entities
{
    public class DossierWorkActivitiesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DwaId { get; set; }

        public Guid? DwaDossierId { get; set; }

        public Guid? DwaDossierAssignmentId { get; set; }

        public Guid? DwaWorkActivityId { get; set; }

        public Guid? DwaDossierPartyId { get; set; }

        public Guid? DwaInvolvedObjectId { get; set; }

        public Guid? DwaInvolvedCoverageId { get; set; }

        public Guid? DwaActivityExecutionId { get; set; }

        public Guid? DwaActivityOptionId { get; set; }

        public DateTime? DwaCreatedDate { get; set; }

        public string? DwaCreatedBy { get; set; }

        public DateTime? DwaLastModifiedDate { get; set; }

        public string? DwaLastModifiedBy { get; set; }

        public bool? DwaInactive { get; set; }

        public Guid? DwaProductId { get; set; }
    }
}