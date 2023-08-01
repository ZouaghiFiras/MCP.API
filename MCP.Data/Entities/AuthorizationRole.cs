namespace CED.Data.Entities
{
    public class AuthorizationRole
    {
        public string AurId { get; set; } = null!;

        public byte[] AurTimeStamp { get; set; } = null!;

        public string? AurAuthorizationRoleTypeId { get; set; }

        public DateTime AurCreatedDate { get; set; }

        public string? AurCreatedBy { get; set; }

        public DateTime AurLastModifiedDate { get; set; }

        public string? AurLastModifiedBy { get; set; }

        public bool AurIsMiddleOfficeRole { get; set; }

        public virtual AuthorizationRoleType? AurAuthorizationRoleType { get; set; }

        public virtual AuthorizationGroupRole? AuthorizationGroupRole { get; set; }

        public virtual ICollection<AuthorizationRoleInheritance> AuthorizationRoleInheritances { get; } =
            new List<AuthorizationRoleInheritance>();

        public virtual ICollection<DossierApproval> DossierApprovals { get; } = new List<DossierApproval>();

        public virtual ICollection<DossierAssignmentCorrectionApproval> DossierAssignmentCorrectionApprovals { get; } =
            new List<DossierAssignmentCorrectionApproval>();

        public virtual ICollection<DossierAssignmentCorrectionAuthorization> DossierAssignmentCorrectionAuthorizations
        {
            get;
        } = new List<DossierAssignmentCorrectionAuthorization>();

        public virtual ICollection<DossierAuthorization> DossierAuthorizations { get; } =
            new List<DossierAuthorization>();

        public virtual ICollection<EmployeeAuthorization> EmployeeAuthorizations { get; } =
            new List<EmployeeAuthorization>();

        public virtual ICollection<InsurancePoliciesCorrectionApproval> InsurancePoliciesCorrectionApprovals { get; } =
            new List<InsurancePoliciesCorrectionApproval>();

        public virtual ICollection<InsurancePoliciesCorrectionAuthorization> InsurancePoliciesCorrectionAuthorizations
        {
            get;
        } = new List<InsurancePoliciesCorrectionAuthorization>();

        public virtual ICollection<PurchaseAuthorizationLimit> PurchaseAuthorizationLimits { get; } =
            new List<PurchaseAuthorizationLimit>();

        public virtual ICollection<PurchaseInvoiceApproval> PurchaseInvoiceApprovals { get; } =
            new List<PurchaseInvoiceApproval>();

        public virtual ICollection<PurchaseInvoiceAuthorization> PurchaseInvoiceAuthorizations { get; } =
            new List<PurchaseInvoiceAuthorization>();

        public virtual ICollection<PurchaseOrderApproval> PurchaseOrderApprovals { get; } =
            new List<PurchaseOrderApproval>();

        public virtual ICollection<PurchaseOrderAuthorization> PurchaseOrderAuthorizations { get; } =
            new List<PurchaseOrderAuthorization>();

        public virtual ICollection<SalesOrderApproval> SalesOrderApprovals { get; } = new List<SalesOrderApproval>();

        public virtual ICollection<SalesOrderAuthorization> SalesOrderAuthorizations { get; } =
            new List<SalesOrderAuthorization>();

        public virtual ICollection<SalesOrderCorrectionApproval> SalesOrderCorrectionApprovals { get; } =
            new List<SalesOrderCorrectionApproval>();

        public virtual ICollection<SalesOrderCorrectionAuthorization> SalesOrderCorrectionAuthorizations { get; } =
            new List<SalesOrderCorrectionAuthorization>();

        public virtual ICollection<TimeSheetApproval> TimeSheetApprovals { get; } = new List<TimeSheetApproval>();

        public virtual ICollection<TimeSheetAuthorization> TimeSheetAuthorizations { get; } =
            new List<TimeSheetAuthorization>();

        public virtual ICollection<WorkingOrderLineCorrectionApproval> WorkingOrderLineCorrectionApprovals { get; } =
            new List<WorkingOrderLineCorrectionApproval>();

        public virtual ICollection<WorkingOrderLineCorrectionAuthorization> WorkingOrderLineCorrectionAuthorizations
        {
            get;
        } = new List<WorkingOrderLineCorrectionAuthorization>();
    }
}