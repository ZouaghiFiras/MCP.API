namespace CED.Data.Entities
{
    public class DossierAssignmentPartiesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DapId { get; set; }

        public Guid? DapDossierPartyId { get; set; }

        public Guid? DapDossierAssignmentId { get; set; }

        public DateTime? DapCreatedDate { get; set; }

        public string? DapCreatedBy { get; set; }

        public DateTime? DapLastModifiedDate { get; set; }

        public string? DapLastModifiedBy { get; set; }
    }
}