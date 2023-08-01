namespace CED.Data.Entities
{
    public class DossierPartyRolesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DprId { get; set; }

        public Guid? DprDossierPartyId { get; set; }

        public Guid? DprRoleCodeId { get; set; }

        public DateTime? DprCreatedDate { get; set; }

        public string? DprCreatedBy { get; set; }

        public DateTime? DprLastModifiedDate { get; set; }

        public string? DprLastModifiedBy { get; set; }
    }
}