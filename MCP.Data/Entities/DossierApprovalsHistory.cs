namespace CED.Data.Entities
{
    public class DossierApprovalsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DapId { get; set; }

        public Guid? DapDossierAuthorizationId { get; set; }

        public DateTime? DapApprovalDate { get; set; }

        public bool? DapIsApproved { get; set; }

        public string? DapComment { get; set; }

        public Guid? DapEmployeeId { get; set; }

        public string? DapAutorizationRoleId { get; set; }

        public DateTime? DapCreatedDate { get; set; }

        public string? DapCreatedBy { get; set; }

        public DateTime? DapLastModifiedDate { get; set; }

        public string? DapLastModifiedBy { get; set; }
    }
}