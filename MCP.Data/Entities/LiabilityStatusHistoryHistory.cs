namespace CED.Data.Entities
{
    public class LiabilityStatusHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? LshId { get; set; }

        public Guid? LshDossierPartyId { get; set; }

        public Guid? LshLiabilityStatusId { get; set; }

        public bool? LshIsLiabilityConfirmed { get; set; }

        public Guid? LshEmployeeId { get; set; }

        public DateTime? LshStartDate { get; set; }

        public DateTime? LshCreatedDate { get; set; }

        public string? LshCreatedBy { get; set; }

        public DateTime? LshLastModifiedDate { get; set; }

        public string? LshLastModifiedBy { get; set; }
    }
}