namespace CED.Data.Entities
{
    public class Client
    {
        public Guid ClId { get; set; }

        public byte[] ClTimeStamp { get; set; } = null!;

        public string? ClExternalCode { get; set; }

        public string? ClCultureCodePreferredLanguage { get; set; }

        public string? ClCurrencyCode { get; set; }

        public bool? ClInactive { get; set; }

        public DateTime ClCreatedDate { get; set; }

        public string? ClCreatedBy { get; set; }

        public DateTime ClLastModifiedDate { get; set; }

        public string? ClLastModifiedBy { get; set; }

        public virtual ICollection<BankStatementReconcilliation> BankStatementReconcilliations { get; } =
            new List<BankStatementReconcilliation>();

        public virtual OrganizationUnit Cl { get; set; } = null!;

        public virtual ICollection<ClaimReserf> ClaimReserves { get; } = new List<ClaimReserf>();

        public virtual ICollection<ClientAgent> ClientAgents { get; } = new List<ClientAgent>();

        public virtual ICollection<ClientInsuranceProduct> ClientInsuranceProductCipClients { get; } =
            new List<ClientInsuranceProduct>();

        public virtual ICollection<ClientInsuranceProduct> ClientInsuranceProductCipDebtorClients { get; } =
            new List<ClientInsuranceProduct>();

        public virtual ICollection<ClientInvoiceDeliveryMethod> ClientInvoiceDeliveryMethods { get; } =
            new List<ClientInvoiceDeliveryMethod>();

        public virtual ICollection<ClientInvoiceRecipient> ClientInvoiceRecipients { get; } =
            new List<ClientInvoiceRecipient>();

        public virtual ICollection<ClientInvoiceRuleMethod> ClientInvoiceRuleMethods { get; } =
            new List<ClientInvoiceRuleMethod>();

        public virtual ICollection<ClientMandate> ClientMandates { get; } = new List<ClientMandate>();

        public virtual ICollection<ClientPreferredSupplier> ClientPreferredSuppliers { get; } =
            new List<ClientPreferredSupplier>();

        public virtual ICollection<ClientTemplate> ClientTemplates { get; } = new List<ClientTemplate>();

        public virtual ICollection<CostFeeSettlement> CostFeeSettlements { get; } = new List<CostFeeSettlement>();

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();

        public virtual ICollection<FeeSettlementLineOperationalClient> FeeSettlementLineOperationalClients { get; } =
            new List<FeeSettlementLineOperationalClient>();

        public virtual ICollection<FeeSettlement> FeeSettlements { get; } = new List<FeeSettlement>();

        public virtual ICollection<FundingsPayment> FundingsPayments { get; } = new List<FundingsPayment>();

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; } = new List<InsurancePolicy>();

        public virtual ICollection<MainContract> MainContracts { get; } = new List<MainContract>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesOrderApprovalSetting> SalesOrderApprovalSettings { get; } =
            new List<SalesOrderApprovalSetting>();

        public virtual ICollection<SalesOrderCorrectionLine> SalesOrderCorrectionLines { get; } =
            new List<SalesOrderCorrectionLine>();

        public virtual ICollection<SalesOrderDraftApprovalSetting> SalesOrderDraftApprovalSettings { get; } =
            new List<SalesOrderDraftApprovalSetting>();

        public virtual ICollection<SalesOrder> SalesOrders { get; } = new List<SalesOrder>();

        public virtual ICollection<SalesSettlement> SalesSettlements { get; } = new List<SalesSettlement>();

        public virtual ICollection<SalesTaxCode> SalesTaxCodes { get; } = new List<SalesTaxCode>();

        public virtual ICollection<SingleInvoiceRuleLog> SingleInvoiceRuleLogs { get; } =
            new List<SingleInvoiceRuleLog>();
    }
}