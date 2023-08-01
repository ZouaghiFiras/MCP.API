namespace CED.Data.Entities
{
    public class AssistancePlan
    {
        public Guid AspId { get; set; }

        public byte[] AspTimeStamp { get; set; } = null!;

        public string AspAssistancePlanNumber { get; set; } = null!;

        public Guid AspAssistancePlanTypeId { get; set; }

        public Guid AspDossierId { get; set; }

        public DateTime AspStartDate { get; set; }

        public string? AspLeadCurrencyCode { get; set; }

        public string? AspForeignCurrencyCode { get; set; }

        public Guid AspSupplierId { get; set; }

        public string? AspSupplierComments { get; set; }

        public Guid? AspPickupLocationId { get; set; }

        public string? AspPickupComments { get; set; }

        public Guid? AspDropoffLocationId { get; set; }

        public string? AspDropoffComments { get; set; }

        public bool? AspExpectRepairOnSpot { get; set; }

        public bool? AspRequireDirectTransport { get; set; }

        public string? AspDistanceComments { get; set; }

        public string? AspGeneralComments { get; set; }

        public bool? AspInvoiceRecipientIsLegalEntity { get; set; }

        public Guid? AspInvoiceRecipientId { get; set; }

        public Guid? AspInvolvedObjectId { get; set; }

        public Guid? AspDossierPartyId { get; set; }

        public Guid? AspAssistanceExecutorOrganizationUnitId { get; set; }

        public DateTime? AspActivationDate { get; set; }

        public DateTime? AspExecutionStartDate { get; set; }

        public DateTime? AspExecutionArrivalDate { get; set; }

        public DateTime? AspExecutionEndDate { get; set; }

        public bool? AspLateCancellation { get; set; }

        public string? AspAddtionalComment1 { get; set; }

        public string? AspAddtionalComment2 { get; set; }

        public string? AspAddtionalComment3 { get; set; }

        public string? AspAddtionalComment4 { get; set; }

        public Guid? AspCurrentStatusHistoryId { get; set; }

        public DateTime? AspCurrentStatusHistoryStartDate { get; set; }

        public string? AspCurrentStatusCode { get; set; }

        public DateTime AspCreatedDate { get; set; }

        public string? AspCreatedBy { get; set; }

        public DateTime AspLastModifiedDate { get; set; }

        public string? AspLastModifiedBy { get; set; }

        public virtual OrganizationUnit? AspAssistanceExecutorOrganizationUnit { get; set; }

        public virtual AssistancePlanType AspAssistancePlanType { get; set; } = null!;

        public virtual Dossier AspDossier { get; set; } = null!;

        public virtual DossierParty? AspDossierParty { get; set; }

        public virtual AssistancePlanLocation? AspDropoffLocation { get; set; }

        public virtual OrganizationUnit? AspInvoiceRecipient { get; set; }

        public virtual InvolvedObject? AspInvolvedObject { get; set; }

        public virtual AssistancePlanLocation? AspPickupLocation { get; set; }

        public virtual Supplier AspSupplier { get; set; } = null!;

        public virtual ICollection<AssistancePlanLine> AssistancePlanLines { get; } = new List<AssistancePlanLine>();

        public virtual ICollection<AssistancePlanStatusHistory> AssistancePlanStatusHistories { get; } =
            new List<AssistancePlanStatusHistory>();

        public virtual ICollection<PurchaseBacklogAssistancePlan> PurchaseBacklogAssistancePlans { get; } =
            new List<PurchaseBacklogAssistancePlan>();

        public virtual ICollection<PurchaseBacklogLine> PurchaseBacklogLines { get; } = new List<PurchaseBacklogLine>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<SingleInvoiceRuleLog> SingleInvoiceRuleLogs { get; } =
            new List<SingleInvoiceRuleLog>();
    }
}