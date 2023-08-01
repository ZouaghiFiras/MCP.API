namespace CED.Data.Entities
{
    public class DossierPartiesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DopId { get; set; }

        public Guid? DopDossierId { get; set; }

        public Guid? DopDossierAssignmentId { get; set; }

        public int? DopPartyOrder { get; set; }

        public Guid? DopInvolvedPartyRoleId { get; set; }

        public Guid? DopInvolvedPartySubRoleId { get; set; }

        public Guid? DopReferalDossierPartyId { get; set; }

        public Guid? DopInvolvedPartyId { get; set; }

        public Guid? DopKnownOrganizationUnitId { get; set; }

        public string? DopCrcommunityAddress { get; set; }

        public string? DopReference { get; set; }

        public bool? DopIsActive { get; set; }

        public bool? DopIsClearinghuisParticipant { get; set; }

        public bool? DopNoFraud { get; set; }

        public DateTime? DopCreatedDate { get; set; }

        public string? DopCreatedBy { get; set; }

        public DateTime? DopLastModifiedDate { get; set; }

        public string? DopLastModifiedBy { get; set; }
    }
}