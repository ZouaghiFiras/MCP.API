namespace CED.Data.Entities
{
    public class DossierAssignment
    {
        public Guid DoaId { get; set; }

        public byte[] DoaTimeStamp { get; set; } = null!;

        public string DoaAssignmentNumber { get; set; } = null!;

        public Guid DoaDossierId { get; set; }

        public Guid? DoaDepartmentId { get; set; }

        public Guid? DoaPartnerId { get; set; }

        public short DoaAssignmentTypeId { get; set; }

        public string DoaCurrencyCode { get; set; } = null!;

        public Guid? DoaCurrentStatusHistoryId { get; set; }

        public DateTime? DoaCurrentStatusHistoryStartDate { get; set; }

        public string? DoaCurrentStatusCode { get; set; }

        public DateTime DoaCreatedDate { get; set; }

        public string? DoaCreatedBy { get; set; }

        public DateTime DoaLastModifiedDate { get; set; }

        public string? DoaLastModifiedBy { get; set; }

        public Guid? DoaInvolvedObjectId { get; set; }

        public Guid? DoaInvolvedCoverageId { get; set; }

        public Guid? DoaProductId { get; set; }

        public Guid? DoaEmployeeId { get; set; }

        public string? DoaClientCaseNumber { get; set; }

        public string? DoaClientOrderNumber { get; set; }

        public decimal? DoaDamageAmountEstimate { get; set; }

        public virtual ICollection<ClaimReserveLine> ClaimReserveLines { get; } = new List<ClaimReserveLine>();

        public virtual ICollection<ClaimReserf> ClaimReserves { get; } = new List<ClaimReserf>();

        public virtual DossierAssignmentType DoaAssignmentType { get; set; } = null!;

        public virtual Department? DoaDepartment { get; set; }

        public virtual Dossier DoaDossier { get; set; } = null!;

        public virtual InvolvedCoverage? DoaInvolvedCoverage { get; set; }

        public virtual InvolvedObject? DoaInvolvedObject { get; set; }

        public virtual Partner? DoaPartner { get; set; }

        public virtual Product? DoaProduct { get; set; }

        public virtual ICollection<DossierAssignmentClosingHistory> DossierAssignmentClosingHistories { get; } =
            new List<DossierAssignmentClosingHistory>();

        public virtual ICollection<DossierAssignmentCorrectionAuthorization> DossierAssignmentCorrectionAuthorizations
        {
            get;
        } = new List<DossierAssignmentCorrectionAuthorization>();

        public virtual DossierAssignmentCurrentStatus? DossierAssignmentCurrentStatus { get; set; }

        public virtual ICollection<DossierAssignmentHandlerHistory> DossierAssignmentHandlerHistories { get; } =
            new List<DossierAssignmentHandlerHistory>();

        public virtual ICollection<DossierAssignmentInvolvedObject> DossierAssignmentInvolvedObjects { get; } =
            new List<DossierAssignmentInvolvedObject>();

        public virtual ICollection<DossierAssignmentLogHistory> DossierAssignmentLogHistories { get; } =
            new List<DossierAssignmentLogHistory>();

        public virtual ICollection<DossierAssignmentNote> DossierAssignmentNotes { get; } =
            new List<DossierAssignmentNote>();

        public virtual ICollection<DossierAssignmentOperationalStatusHistory>
            DossierAssignmentOperationalStatusHistories { get; } =
            new List<DossierAssignmentOperationalStatusHistory>();

        public virtual ICollection<DossierAssignmentParty> DossierAssignmentParties { get; } =
            new List<DossierAssignmentParty>();

        public virtual ICollection<DossierAssignmentStatusHistory> DossierAssignmentStatusHistories { get; } =
            new List<DossierAssignmentStatusHistory>();

        public virtual ICollection<DossierAssignmentVisitInformation> DossierAssignmentVisitInformations { get; } =
            new List<DossierAssignmentVisitInformation>();

        public virtual ICollection<DossierParty> DossierParties { get; } = new List<DossierParty>();

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual ICollection<KeyPerformanceIndicatorTrigger> KeyPerformanceIndicatorTriggers { get; } =
            new List<KeyPerformanceIndicatorTrigger>();

        public virtual ICollection<Post> Posts { get; } = new List<Post>();

        public virtual ICollection<PurchaseBacklogLine> PurchaseBacklogLines { get; } = new List<PurchaseBacklogLine>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoiceDossierAssignment> PurchaseInvoiceDossierAssignments { get; } =
            new List<PurchaseInvoiceDossierAssignment>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<RecoveryStatement> RecoveryStatements { get; } = new List<RecoveryStatement>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual ICollection<SalesOrder> SalesOrders { get; } = new List<SalesOrder>();

        public virtual ICollection<SingleInvoiceRuleLog> SingleInvoiceRuleLogs { get; } =
            new List<SingleInvoiceRuleLog>();

        public virtual ICollection<WorkingOrder> WorkingOrders { get; } = new List<WorkingOrder>();
    }
}