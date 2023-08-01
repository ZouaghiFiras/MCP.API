namespace CED.Data.Entities
{
    public class Debtor
    {
        public Guid DbId { get; set; }

        public byte[] DbTimeStamp { get; set; } = null!;

        public string DbNumber { get; set; } = null!;

        public string DbName { get; set; } = null!;

        public string? DbName2 { get; set; }

        public string? DbName3 { get; set; }

        public string? DbSearchText { get; set; }

        public bool DbIsCompany { get; set; }

        public short? DbGenderId { get; set; }

        public string? DbPhone { get; set; }

        public string? DbPhoneExt { get; set; }

        public string? DbFax { get; set; }

        public string? DbEmail { get; set; }

        public string? DbHomePage { get; set; }

        public Guid? DbAddressId { get; set; }

        public Guid? DbPostOfficeBoxId { get; set; }

        public Guid DbLegalEntityId { get; set; }

        public string? DbLedgerAccount { get; set; }

        public string? DbEntrySystem { get; set; }

        public string? DbEntryNumber { get; set; }

        public string? DbEntryBatch { get; set; }

        public string? DbVatNumber { get; set; }

        public bool DbNoVatNumber { get; set; }

        public string? DbChamberOfCommerceNumber { get; set; }

        public Guid? DbBankAccountId { get; set; }

        public bool DbInactive { get; set; }

        public Guid? DbTenantId { get; set; }

        public string? DbSalesTaxCodeId { get; set; }

        public DateTime? DbExactExportDate { get; set; }

        public Guid? DbDefaultClientId { get; set; }

        public string? DbContactPersonName { get; set; }

        public string? DbContactPersonPhone { get; set; }

        public string? DbContactPersonEmail { get; set; }

        public string? DbInvoiceDeliveryMethodId { get; set; }

        public string? DbSalesCollectionEmail { get; set; }

        public bool? DbAutoAuthorizeFeeOrders { get; set; }

        public bool? DbAutoAuthorizeChargedExpensesOrders { get; set; }

        public bool? DbSalesCollectionEnabled { get; set; }

        public DateTime DbCreatedDate { get; set; }

        public string? DbCreatedBy { get; set; }

        public DateTime DbLastModifiedDate { get; set; }

        public string? DbLastModifiedBy { get; set; }

        public bool? DbIsContracted { get; set; }

        public Guid? DbPeriodId { get; set; }

        public string? DbSummaryStatementCreationMethodId { get; set; }

        public string? DbSummaryStatementEmailAddresses { get; set; }

        public bool? DbSummaryStatementAutoCreated { get; set; }

        public Guid? DbExactAccountCategoryId { get; set; }

        public virtual ICollection<ClientInvoiceDeliveryMethod> ClientInvoiceDeliveryMethods { get; } =
            new List<ClientInvoiceDeliveryMethod>();

        public virtual Address? DbAddress { get; set; }

        public virtual BankAccount? DbBankAccount { get; set; }

        public virtual Client? DbDefaultClient { get; set; }

        public virtual ExactAccountCategory? DbExactAccountCategory { get; set; }

        public virtual Gender? DbGender { get; set; }

        public virtual InvoiceDeliveryMethod? DbInvoiceDeliveryMethod { get; set; }

        public virtual LegalEntity DbLegalEntity { get; set; } = null!;

        public virtual SummaryStatementPeriod? DbPeriod { get; set; }

        public virtual PostOfficeBox? DbPostOfficeBox { get; set; }

        public virtual SummaryStatementCreationMethod? DbSummaryStatementCreationMethod { get; set; }

        public virtual Tenant? DbTenant { get; set; }

        public virtual ICollection<DebtorAccount> DebtorAccounts { get; } = new List<DebtorAccount>();

        public virtual ICollection<DebtorAttribute> DebtorAttributes { get; } = new List<DebtorAttribute>();

        public virtual ICollection<DebtorOrganizationRelation> DebtorOrganizationRelations { get; } =
            new List<DebtorOrganizationRelation>();

        public virtual ICollection<DebtorStatusHistory> DebtorStatusHistories { get; } =
            new List<DebtorStatusHistory>();

        public virtual ICollection<DebtorSummaryLayout> DebtorSummaryLayouts { get; } = new List<DebtorSummaryLayout>();

        public virtual ICollection<DebtorTemplate> DebtorTemplates { get; } = new List<DebtorTemplate>();

        public virtual ICollection<JournalEntryLine> JournalEntryLines { get; } = new List<JournalEntryLine>();

        public virtual ICollection<SalesCollectionDebtor> SalesCollectionDebtors { get; } =
            new List<SalesCollectionDebtor>();

        public virtual ICollection<SalesCollection> SalesCollections { get; } = new List<SalesCollection>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();
    }
}