namespace CED.Data.Entities
{
    public class LegalEntity
    {
        public Guid LeId { get; set; }

        public byte[] LeTimeStamp { get; set; } = null!;

        public Guid LeLegalEntityTypeId { get; set; }

        public Guid? LeFiscalEntityId { get; set; }

        public string? LeExactAdministration { get; set; }

        public string LeCurrencyCode { get; set; } = null!;

        public string? LeDocumentNamePrefix { get; set; }

        public string? LeSalesJournalId { get; set; }

        public string? LePurchaseJournalId { get; set; }

        public string? LeConsolidationDebtorNumber { get; set; }

        public string? LeConsolidationCreditorNumber { get; set; }

        public string? LeCreditSalesJournalId { get; set; }

        public string? LeCreditPurchaseJournalId { get; set; }

        public string? LePurchaseMemorialJournalId { get; set; }

        public string? LePrepaymentSuspenseAccount { get; set; }

        public string? LeEqualizationSuspenseAccount { get; set; }

        public Guid? LeDefaultBankAccountId { get; set; }

        public Guid? LeGeneralSupplierId { get; set; }

        public Guid? LeDefaultPaymentConditionId { get; set; }

        public string? LeGeneralDebtorNumberInternal { get; set; }

        public string? LeGeneralDebtorNumberExternal { get; set; }

        public DateTime LeCreatedDate { get; set; }

        public string? LeCreatedBy { get; set; }

        public DateTime LeLastModifiedDate { get; set; }

        public string? LeLastModifiedBy { get; set; }

        public virtual ICollection<ApplicationSetting> ApplicationSettings { get; } = new List<ApplicationSetting>();

        public virtual ICollection<BookingDimension> BookingDimensions { get; } = new List<BookingDimension>();

        public virtual ICollection<BusinessUnit> BusinessUnits { get; } = new List<BusinessUnit>();

        public virtual ICollection<ClaimReserf> ClaimReserves { get; } = new List<ClaimReserf>();

        public virtual ICollection<ClientInvoiceDeliveryMethod> ClientInvoiceDeliveryMethods { get; } =
            new List<ClientInvoiceDeliveryMethod>();

        public virtual ICollection<ClientInvoiceRuleMethod> ClientInvoiceRuleMethods { get; } =
            new List<ClientInvoiceRuleMethod>();

        public virtual ICollection<ClientTemplate> ClientTemplates { get; } = new List<ClientTemplate>();

        public virtual ICollection<CostCenter> CostCenters { get; } = new List<CostCenter>();

        public virtual ICollection<CostFeeSettlement> CostFeeSettlements { get; } = new List<CostFeeSettlement>();

        public virtual ICollection<CostOfSale> CostOfSales { get; } = new List<CostOfSale>();

        public virtual ICollection<CostSettlement> CostSettlements { get; } = new List<CostSettlement>();

        public virtual ICollection<CostUnit> CostUnits { get; } = new List<CostUnit>();

        public virtual ICollection<Creditor> Creditors { get; } = new List<Creditor>();

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();

        public virtual ICollection<EmployeeAuthorization> EmployeeAuthorizations { get; } =
            new List<EmployeeAuthorization>();

        public virtual ICollection<ExactGlobeLegalEntity> ExactGlobeLegalEntities { get; } =
            new List<ExactGlobeLegalEntity>();

        public virtual ICollection<FeeSettlement> FeeSettlements { get; } = new List<FeeSettlement>();

        public virtual ICollection<FinancialBookingPeriod> FinancialBookingPeriods { get; } =
            new List<FinancialBookingPeriod>();

        public virtual ICollection<FundingsPayment> FundingsPayments { get; } = new List<FundingsPayment>();

        public virtual ICollection<HandlingCountry> HandlingCountries { get; } = new List<HandlingCountry>();

        public virtual ICollection<InvoiceType> InvoiceTypes { get; } = new List<InvoiceType>();

        public virtual ICollection<JournalSetting> JournalSettings { get; } = new List<JournalSetting>();

        public virtual ICollection<Journal> Journals { get; } = new List<Journal>();

        public virtual OrganizationUnit Le { get; set; } = null!;

        public virtual Journal? LeCreditPurchaseJournal { get; set; }

        public virtual Journal? LeCreditSalesJournal { get; set; }

        public virtual BankAccount? LeDefaultBankAccount { get; set; }

        public virtual PaymentCondition? LeDefaultPaymentCondition { get; set; }

        public virtual FiscalEntity? LeFiscalEntity { get; set; }

        public virtual Supplier? LeGeneralSupplier { get; set; }

        public virtual LegalEntityType LeLegalEntityType { get; set; } = null!;

        public virtual Journal? LePurchaseJournal { get; set; }

        public virtual Journal? LeSalesJournal { get; set; }

        public virtual ICollection<LedgerSetting> LedgerSettings { get; } = new List<LedgerSetting>();

        public virtual ICollection<LegalEntityAccount> LegalEntityAccounts { get; } = new List<LegalEntityAccount>();

        public virtual ICollection<LegalEntityPaymentMethod> LegalEntityPaymentMethods { get; } =
            new List<LegalEntityPaymentMethod>();

        public virtual ICollection<LegalEntityTaxCategory> LegalEntityTaxCategories { get; } =
            new List<LegalEntityTaxCategory>();

        public virtual ICollection<LocationTaxCode> LocationTaxCodes { get; } = new List<LocationTaxCode>();

        public virtual ICollection<Office> Offices { get; } = new List<Office>();

        public virtual ICollection<OrganizationPaymentMethod> OrganizationPaymentMethods { get; } =
            new List<OrganizationPaymentMethod>();

        public virtual ICollection<OrganizationTaxCode> OrganizationTaxCodes { get; } = new List<OrganizationTaxCode>();

        public virtual ICollection<PaymentCondition> PaymentConditions { get; } = new List<PaymentCondition>();

        public virtual ICollection<PaymentCurrency> PaymentCurrencies { get; } = new List<PaymentCurrency>();

        public virtual ICollection<Post> Posts { get; } = new List<Post>();

        public virtual ICollection<PurchaseAuthorizationLimit> PurchaseAuthorizationLimits { get; } =
            new List<PurchaseAuthorizationLimit>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseLedgerSetting> PurchaseLedgerSettings { get; } =
            new List<PurchaseLedgerSetting>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<PurchaseTaxCode> PurchaseTaxCodes { get; } = new List<PurchaseTaxCode>();

        public virtual ICollection<PurchaseTaxRate> PurchaseTaxRates { get; } = new List<PurchaseTaxRate>();

        public virtual ICollection<RecoveryStatement> RecoveryStatements { get; } = new List<RecoveryStatement>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesLedgerSetting> SalesLedgerSettings { get; } = new List<SalesLedgerSetting>();

        public virtual ICollection<SalesOrderApprovalSetting> SalesOrderApprovalSettings { get; } =
            new List<SalesOrderApprovalSetting>();

        public virtual ICollection<SalesOrderDraftApprovalSetting> SalesOrderDraftApprovalSettings { get; } =
            new List<SalesOrderDraftApprovalSetting>();

        public virtual ICollection<SalesOrder> SalesOrders { get; } = new List<SalesOrder>();

        public virtual ICollection<SalesSettlement> SalesSettlements { get; } = new List<SalesSettlement>();

        public virtual ICollection<SalesTaxCode> SalesTaxCodes { get; } = new List<SalesTaxCode>();

        public virtual ICollection<SalesTaxRate> SalesTaxRates { get; } = new List<SalesTaxRate>();

        public virtual ICollection<ServiceTaxRate> ServiceTaxRates { get; } = new List<ServiceTaxRate>();

        public virtual ICollection<SubContract> SubContracts { get; } = new List<SubContract>();

        public virtual ICollection<SupplierInvoiceDeliveryMethod> SupplierInvoiceDeliveryMethods { get; } =
            new List<SupplierInvoiceDeliveryMethod>();
    }
}