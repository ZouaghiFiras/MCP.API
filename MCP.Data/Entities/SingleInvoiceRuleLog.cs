namespace CED.Data.Entities
{
    public class SingleInvoiceRuleLog
    {
        public Guid SrlId { get; set; }

        public byte[] SrlTimeStamp { get; set; } = null!;

        public bool SrlIsClosed { get; set; }

        public Guid SrlClientId { get; set; }

        public Guid SrlDossierId { get; set; }

        public Guid? SrlDossierAssignmentId { get; set; }

        public Guid? SrlAssistancePlanId { get; set; }

        public bool SrlPurchaseInvoicesCompletedCheck { get; set; }

        public DateTime? SrlPurchaseInvoicesCompletedDate { get; set; }

        public bool SrlSalesOrdersCompletedCheck { get; set; }

        public DateTime? SrlSalesOrdersCompletedDate { get; set; }

        public bool SrlFeeCompletedCheck { get; set; }

        public DateTime? SrlFeeCompletedDate { get; set; }

        public bool SrlScheduleEventCompletedCheck { get; set; }

        public DateTime? SrlScheduleEventCompletedDate { get; set; }

        public bool SrlEmployeeCompletedCheck { get; set; }

        public DateTime? SrlEmployeeCompletedDate { get; set; }

        public Guid? SrlEmployeeCompletedEmployeeId { get; set; }

        public string? SrlEmployeeCompletedReason { get; set; }

        public DateTime SrlCreatedDate { get; set; }

        public string? SrlCreatedBy { get; set; }

        public DateTime SrlLastModifiedDate { get; set; }

        public string? SrlLastModifiedBy { get; set; }

        public virtual AssistancePlan? SrlAssistancePlan { get; set; }

        public virtual Client SrlClient { get; set; } = null!;

        public virtual Dossier SrlDossier { get; set; } = null!;

        public virtual DossierAssignment? SrlDossierAssignment { get; set; }
    }
}