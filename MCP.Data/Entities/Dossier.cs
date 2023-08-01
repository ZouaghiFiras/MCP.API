namespace CED.Data.Entities
{
    public class Dossier
    {
        public Guid DosId { get; set; }

        public byte[] DosTimeStamp { get; set; } = null!;

        public string? DosDossierNumber { get; set; }

        public Guid DosClientId { get; set; }

        public Guid? DosMandateId { get; set; }

        public Guid? DosAgentId { get; set; }

        public Guid? DosContactPersonId { get; set; }

        public Guid DosProductId { get; set; }

        public Guid? DosEmployeeId { get; set; }

        public Guid? DosTenantId { get; set; }

        public short? DosDossierTypeId { get; set; }

        public string? DosEntrySystem { get; set; }

        public string? DosEntryNumber { get; set; }

        public string? DosEntryBatch { get; set; }

        public Guid? DosLegalEntityId { get; set; }

        public Guid? DosDepartmentId { get; set; }

        public Guid? DosCurrentStatusHistoryId { get; set; }

        public DateTime? DosCurrentStatusHistoryStartDate { get; set; }

        public string? DosCurrentStatusCode { get; set; }

        public DateTime DosCreatedDate { get; set; }

        public string? DosCreatedBy { get; set; }

        public DateTime DosLastModifiedDate { get; set; }

        public string? DosLastModifiedBy { get; set; }

        public Guid? DosDossierPriorityId { get; set; }

        public Guid? DosReporterId { get; set; }

        public DateTime? DosIntakeDate { get; set; }

        public DateTime? DosIncidentDate { get; set; }

        public Guid? DosReasonId { get; set; }

        public Guid? DosCauseId { get; set; }

        public Guid? DosMainReasonId { get; set; }

        public Guid? DosSubReasonId { get; set; }

        public string? DosIncidentCountryId { get; set; }

        public virtual AdviceDossier? AdviceDossier { get; set; }

        public virtual AssistanceDossier? AssistanceDossier { get; set; }

        public virtual ICollection<AssistancePlan> AssistancePlans { get; } = new List<AssistancePlan>();

        public virtual ICollection<AutomaticMessageLog> AutomaticMessageLogs { get; } = new List<AutomaticMessageLog>();

        public virtual ICollection<BankStatementReconcilliation> BankStatementReconcilliations { get; } =
            new List<BankStatementReconcilliation>();

        public virtual ClaimDossier? ClaimDossier { get; set; }

        public virtual ICollection<ClaimReserf> ClaimReserves { get; } = new List<ClaimReserf>();

        public virtual CrossBorderClaimDossier? CrossBorderClaimDossier { get; set; }

        public virtual Agent? DosAgent { get; set; }

        public virtual DamageReason? DosCause { get; set; }

        public virtual Client DosClient { get; set; } = null!;

        public virtual ContactPerson? DosContactPerson { get; set; }

        public virtual Department? DosDepartment { get; set; }

        public virtual DossierPriority? DosDossierPriority { get; set; }

        public virtual DossierType? DosDossierType { get; set; }

        public virtual Country? DosIncidentCountry { get; set; }

        public virtual LegalEntity? DosLegalEntity { get; set; }

        public virtual DamageReason? DosMainReason { get; set; }

        public virtual Mandate? DosMandate { get; set; }

        public virtual Product DosProduct { get; set; } = null!;

        public virtual DamageReason? DosReason { get; set; }

        public virtual OrganizationUnit? DosReporter { get; set; }

        public virtual DamageReason? DosSubReason { get; set; }

        public virtual Tenant? DosTenant { get; set; }

        public virtual ICollection<DossierAssignment> DossierAssignments { get; } = new List<DossierAssignment>();

        public virtual ICollection<DossierAttachment> DossierAttachments { get; } = new List<DossierAttachment>();

        public virtual ICollection<DossierAuthorization> DossierAuthorizations { get; } =
            new List<DossierAuthorization>();

        public virtual ICollection<DossierClientHandlerHistory> DossierClientHandlerHistories { get; } =
            new List<DossierClientHandlerHistory>();

        public virtual ICollection<DossierClosingHistory> DossierClosingHistories { get; } =
            new List<DossierClosingHistory>();

        public virtual ICollection<DossierContactPerson> DossierContactPeople { get; } =
            new List<DossierContactPerson>();

        public virtual ICollection<DossierHandler> DossierHandlers { get; } = new List<DossierHandler>();

        public virtual ICollection<DossierInsuree> DossierInsurees { get; } = new List<DossierInsuree>();

        public virtual ICollection<DossierLine> DossierLines { get; } = new List<DossierLine>();

        public virtual ICollection<DossierLogHistory> DossierLogHistories { get; } = new List<DossierLogHistory>();

        public virtual ICollection<DossierNote> DossierNotes { get; } = new List<DossierNote>();

        public virtual ICollection<DossierOperationalStatusHistory> DossierOperationalStatusHistories { get; } =
            new List<DossierOperationalStatusHistory>();

        public virtual ICollection<DossierParty> DossierParties { get; } = new List<DossierParty>();

        public virtual ICollection<DossierStatusHistory> DossierStatusHistories { get; } =
            new List<DossierStatusHistory>();

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual ICollection<FraudDetectionLog> FraudDetectionLogs { get; } = new List<FraudDetectionLog>();

        public virtual ICollection<FundingsPayment> FundingsPayments { get; } = new List<FundingsPayment>();

        public virtual ICollection<InvolvedCoverage> InvolvedCoverages { get; } = new List<InvolvedCoverage>();

        public virtual ICollection<InvolvedObject> InvolvedObjects { get; } = new List<InvolvedObject>();

        public virtual ICollection<KeyPerformanceIndicatorTrigger> KeyPerformanceIndicatorTriggers { get; } =
            new List<KeyPerformanceIndicatorTrigger>();

        public virtual MedicalDossier? MedicalDossier { get; set; }

        public virtual ICollection<PhotoSheetSetting> PhotoSheetSettings { get; } = new List<PhotoSheetSetting>();

        public virtual ICollection<Post> Posts { get; } = new List<Post>();

        public virtual ICollection<PurchaseBacklogLine> PurchaseBacklogLines { get; } = new List<PurchaseBacklogLine>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<RecoveryStatement> RecoveryStatements { get; } = new List<RecoveryStatement>();

        public virtual ICollection<Regre> Regres { get; } = new List<Regre>();

        public virtual RepairDossier? RepairDossier { get; set; }

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual ICollection<SalesOrder> SalesOrders { get; } = new List<SalesOrder>();

        public virtual ICollection<SingleInvoiceRuleLog> SingleInvoiceRuleLogs { get; } =
            new List<SingleInvoiceRuleLog>();

        public virtual ICollection<VisitInformation> VisitInformations { get; } = new List<VisitInformation>();

        public virtual ICollection<WorkingOrder> WorkingOrders { get; } = new List<WorkingOrder>();
    }
}