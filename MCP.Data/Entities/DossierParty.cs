namespace CED.Data.Entities
{
    public class DossierParty
    {
        public Guid DopId { get; set; }

        public byte[] DopTimeStamp { get; set; } = null!;

        public Guid DopDossierId { get; set; }

        public Guid? DopDossierAssignmentId { get; set; }

        public int? DopPartyOrder { get; set; }

        public Guid DopInvolvedPartyRoleId { get; set; }

        public Guid? DopInvolvedPartySubRoleId { get; set; }

        public Guid? DopReferalDossierPartyId { get; set; }

        public Guid? DopInvolvedPartyId { get; set; }

        public Guid? DopKnownOrganizationUnitId { get; set; }

        public string? DopCrcommunityAddress { get; set; }

        public string? DopReference { get; set; }

        public bool? DopIsActive { get; set; }

        public bool? DopIsClearinghuisParticipant { get; set; }

        public bool? DopNoFraud { get; set; }

        public DateTime DopCreatedDate { get; set; }

        public string? DopCreatedBy { get; set; }

        public DateTime DopLastModifiedDate { get; set; }

        public string? DopLastModifiedBy { get; set; }

        public virtual ICollection<AssistancePlan> AssistancePlans { get; } = new List<AssistancePlan>();

        public virtual ICollection<ClaimReserf> ClaimReserves { get; } = new List<ClaimReserf>();

        public virtual Dossier DopDossier { get; set; } = null!;

        public virtual DossierAssignment? DopDossierAssignment { get; set; }

        public virtual InvolvedParty? DopInvolvedParty { get; set; }

        public virtual RoleCode DopInvolvedPartyRole { get; set; } = null!;

        public virtual RoleCode? DopInvolvedPartySubRole { get; set; }

        public virtual OrganizationUnit? DopKnownOrganizationUnit { get; set; }

        public virtual ICollection<DossierAssignmentParty> DossierAssignmentParties { get; } =
            new List<DossierAssignmentParty>();

        public virtual ICollection<DossierInsuree> DossierInsurees { get; } = new List<DossierInsuree>();

        public virtual ICollection<DossierPartyInvolvedCoverage> DossierPartyInvolvedCoverages { get; } =
            new List<DossierPartyInvolvedCoverage>();

        public virtual ICollection<DossierPartyObjectRelation> DossierPartyObjectRelations { get; } =
            new List<DossierPartyObjectRelation>();

        public virtual ICollection<DossierPartyRole> DossierPartyRoles { get; } = new List<DossierPartyRole>();

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual ICollection<LiabilityStatusHistory> LiabilityStatusHistories { get; } =
            new List<LiabilityStatusHistory>();

        public virtual ICollection<OvsRegre> OvsRegres { get; } = new List<OvsRegre>();

        public virtual ICollection<Payment> Payments { get; } = new List<Payment>();

        public virtual ICollection<Post> Posts { get; } = new List<Post>();

        public virtual ICollection<PurchaseBacklogLine> PurchaseBacklogLines { get; } = new List<PurchaseBacklogLine>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<RecoveryStatement> RecoveryStatements { get; } = new List<RecoveryStatement>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual ICollection<SalesOrder> SalesOrders { get; } = new List<SalesOrder>();

        public virtual ICollection<WorkingOrderLineCost> WorkingOrderLineCosts { get; } =
            new List<WorkingOrderLineCost>();

        public virtual ICollection<WorkingOrderLine> WorkingOrderLines { get; } = new List<WorkingOrderLine>();

        public virtual ICollection<WorkingOrderParty> WorkingOrderParties { get; } = new List<WorkingOrderParty>();
    }
}