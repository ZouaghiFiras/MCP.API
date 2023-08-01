namespace CED.Data.Entities
{
    public class Employee
    {
        public Guid EmpId { get; set; }

        public byte[] EmpTimeStamp { get; set; } = null!;

        public string? EmpEmployeeNumber { get; set; }

        public string? EmpEisNumber { get; set; }

        public string? EmpInitials { get; set; }

        public string? EmpFirstName { get; set; }

        public string? EmpPrefixLastName { get; set; }

        public string EmpLastName { get; set; } = null!;

        public string? EmpFullName { get; set; }

        public string? EmpPhoneNumber { get; set; }

        public string? EmpMobileNumber { get; set; }

        public string? EmpEmail { get; set; }

        public Guid? EmpJobId { get; set; }

        public Guid? EmpDepartmentId { get; set; }

        public Guid? EmpRegionId { get; set; }

        public Guid? EmpManagerId { get; set; }

        public DateTime? EmpEnrollmentDate { get; set; }

        public DateTime? EmpEmploymentTerminationDate { get; set; }

        public bool EmpInactive { get; set; }

        public DateTime EmpCreatedDate { get; set; }

        public string? EmpCreatedBy { get; set; }

        public DateTime EmpLastModifiedDate { get; set; }

        public string? EmpLastModifiedBy { get; set; }

        public bool EmpIsExpert { get; set; }

        public Guid? EmpTeamId { get; set; }

        public Guid? EmpSalutationId { get; set; }

        public string? EmpFax { get; set; }

        public string? EmpNumberFormat { get; set; }

        public string? EmpCultureCodePreferredLanguage { get; set; }

        public string? EmpEmailSignature { get; set; }

        public virtual ICollection<AssistancePlanStatusHistory> AssistancePlanStatusHistories { get; } =
            new List<AssistancePlanStatusHistory>();

        public virtual ICollection<BankAccountValidation> BankAccountValidations { get; } =
            new List<BankAccountValidation>();

        public virtual ICollection<ClaimReserveStatusHistory> ClaimReserveStatusHistories { get; } =
            new List<ClaimReserveStatusHistory>();

        public virtual ICollection<CreditorStatusHistory> CreditorStatusHistories { get; } =
            new List<CreditorStatusHistory>();

        public virtual ICollection<DebtorStatusHistory> DebtorStatusHistories { get; } =
            new List<DebtorStatusHistory>();

        public virtual ICollection<DossierApproval> DossierApprovals { get; } = new List<DossierApproval>();

        public virtual ICollection<DossierAssignmentCorrectionApproval> DossierAssignmentCorrectionApprovals { get; } =
            new List<DossierAssignmentCorrectionApproval>();

        public virtual ICollection<DossierAssignmentHandlerHistory> DossierAssignmentHandlerHistories { get; } =
            new List<DossierAssignmentHandlerHistory>();

        public virtual Department? EmpDepartment { get; set; }

        public virtual Job? EmpJob { get; set; }

        public virtual Employee? EmpManager { get; set; }

        public virtual Region? EmpRegion { get; set; }

        public virtual Salutation? EmpSalutation { get; set; }

        public virtual Team? EmpTeam { get; set; }

        public virtual ICollection<EmployeeAuthorization> EmployeeAuthorizations { get; } =
            new List<EmployeeAuthorization>();

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; } = new List<EmployeeSkill>();

        public virtual ICollection<EmployeeTeam> EmployeeTeams { get; } = new List<EmployeeTeam>();

        public virtual ICollection<InsurancePoliciesCorrectionApproval> InsurancePoliciesCorrectionApprovals { get; } =
            new List<InsurancePoliciesCorrectionApproval>();

        public virtual ICollection<Employee> InverseEmpManager { get; } = new List<Employee>();

        public virtual ICollection<JournalEntryStatusHistory> JournalEntryStatusHistories { get; } =
            new List<JournalEntryStatusHistory>();

        public virtual ICollection<OrganizationAccountValidation> OrganizationAccountValidations { get; } =
            new List<OrganizationAccountValidation>();

        public virtual ICollection<OrganizationVatValidation> OrganizationVatValidations { get; } =
            new List<OrganizationVatValidation>();

        public virtual ICollection<Payment> Payments { get; } = new List<Payment>();

        public virtual ICollection<Post> Posts { get; } = new List<Post>();

        public virtual ICollection<PurchaseBacklogStatusHistory> PurchaseBacklogStatusHistories { get; } =
            new List<PurchaseBacklogStatusHistory>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoiceApproval> PurchaseInvoiceApprovals { get; } =
            new List<PurchaseInvoiceApproval>();

        public virtual ICollection<PurchaseInvoiceStatusHistory> PurchaseInvoiceStatusHistories { get; } =
            new List<PurchaseInvoiceStatusHistory>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseOrderApproval> PurchaseOrderApprovals { get; } =
            new List<PurchaseOrderApproval>();

        public virtual ICollection<PurchaseOrderConfirmation> PurchaseOrderConfirmations { get; } =
            new List<PurchaseOrderConfirmation>();

        public virtual ICollection<PurchaseOrderStatusHistory> PurchaseOrderStatusHistories { get; } =
            new List<PurchaseOrderStatusHistory>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<PurchasePaymentBatch> PurchasePaymentBatches { get; } =
            new List<PurchasePaymentBatch>();

        public virtual ICollection<PurchasePaymentStatusHistory> PurchasePaymentStatusHistories { get; } =
            new List<PurchasePaymentStatusHistory>();

        public virtual ICollection<PurchaseReceipt> PurchaseReceipts { get; } = new List<PurchaseReceipt>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesOrderApproval> SalesOrderApprovals { get; } = new List<SalesOrderApproval>();

        public virtual ICollection<SalesOrderCorrectionApproval> SalesOrderCorrectionApprovals { get; } =
            new List<SalesOrderCorrectionApproval>();

        public virtual ICollection<SalesOrderCorrectionAuthorization> SalesOrderCorrectionAuthorizations { get; } =
            new List<SalesOrderCorrectionAuthorization>();

        public virtual ICollection<TaskCompletion> TaskCompletions { get; } = new List<TaskCompletion>();

        public virtual ICollection<TaskMember> TaskMembers { get; } = new List<TaskMember>();

        public virtual ICollection<TaskNote> TaskNotes { get; } = new List<TaskNote>();

        public virtual ICollection<Team> Teams { get; } = new List<Team>();

        public virtual ICollection<TimeSheetApproval> TimeSheetApprovals { get; } = new List<TimeSheetApproval>();

        public virtual ICollection<TimeSheet> TimeSheets { get; } = new List<TimeSheet>();

        public virtual ICollection<VisitInformation> VisitInformations { get; } = new List<VisitInformation>();

        public virtual ICollection<WebApiClient> WebApiClients { get; } = new List<WebApiClient>();

        public virtual ICollection<WorkingOrderLineCorrectionApproval> WorkingOrderLineCorrectionApprovals { get; } =
            new List<WorkingOrderLineCorrectionApproval>();

        public virtual ICollection<WorkingOrderLineIsExecuteVatDeductableHistory>
            WorkingOrderLineIsExecuteVatDeductableHistories { get; } =
            new List<WorkingOrderLineIsExecuteVatDeductableHistory>();

        public virtual ICollection<WorkingOrderLineIsOwnRiskHistory> WorkingOrderLineIsOwnRiskHistories { get; } =
            new List<WorkingOrderLineIsOwnRiskHistory>();

        public virtual ICollection<WorkingOrder> WorkingOrders { get; } = new List<WorkingOrder>();
    }
}