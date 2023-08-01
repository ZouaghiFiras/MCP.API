namespace CED.Data.Entities
{
    public class OrganizationUnit
    {
        public Guid OuId { get; set; }

        public byte[] OuTimeStamp { get; set; } = null!;

        public string OuCode { get; set; } = null!;

        public string? OuShortName { get; set; }

        public string OuLongName { get; set; } = null!;

        public string? OuLongName2 { get; set; }

        public string? OuLongName3 { get; set; }

        public string? OuPorCode { get; set; }

        public DateTime? OuStartDate { get; set; }

        public DateTime? OuEndDate { get; set; }

        public bool OuInactive { get; set; }

        public Guid? OuOrganizationTypeId { get; set; }

        public Guid? OuHierarchyTypeId { get; set; }

        public Guid? OuAddressId { get; set; }

        public Guid? OuPostOfficeBoxId { get; set; }

        public Guid? OuOrganizationGroupId { get; set; }

        public Guid? OuCollectionCodeId { get; set; }

        public string? OuWebsite { get; set; }

        public string? OuEmail { get; set; }

        public string? OuVatNumber { get; set; }

        public string? OuVatCountryCode { get; set; }

        public bool OuNoVatNumber { get; set; }

        public string? OuChamberOfCommerceNumber { get; set; }

        public DateTime OuCreatedDate { get; set; }

        public string? OuCreatedBy { get; set; }

        public DateTime OuLastModifiedDate { get; set; }

        public string? OuLastModifiedBy { get; set; }

        public string? OuPhone { get; set; }

        public string? OuFax { get; set; }

        public Guid? OuTenantId { get; set; }

        public string? OuSalesTaxCodeId { get; set; }

        public string? OuPurchaseTaxCodeId { get; set; }

        public bool OuIsTaxExempted { get; set; }

        public string? OuTaxExemptNumber { get; set; }

        public bool OuIsNotCompany { get; set; }

        public virtual Agent? Agent { get; set; }

        public virtual AlarmCenter? AlarmCenter { get; set; }

        public virtual ICollection<AssistancePlan> AssistancePlanAspAssistanceExecutorOrganizationUnits { get; } =
            new List<AssistancePlan>();

        public virtual ICollection<AssistancePlan> AssistancePlanAspInvoiceRecipients { get; } =
            new List<AssistancePlan>();

        public virtual Bank? Bank { get; set; }

        public virtual ICollection<BusinessHour> BusinessHours { get; } = new List<BusinessHour>();

        public virtual BusinessUnit? BusinessUnit { get; set; }

        public virtual Client? Client { get; set; }

        public virtual ICollection<ClientInvoiceRecipient> ClientInvoiceRecipients { get; } =
            new List<ClientInvoiceRecipient>();

        public virtual ICollection<ContactPerson> ContactPeople { get; } = new List<ContactPerson>();

        public virtual ContractParty? ContractParty { get; set; }

        public virtual ConvenantParty? ConvenantParty { get; set; }

        public virtual ICollection<CoverageProduct> CoverageProducts { get; } = new List<CoverageProduct>();

        public virtual ICollection<CreditorOrganizationRelation> CreditorOrganizationRelations { get; } =
            new List<CreditorOrganizationRelation>();

        public virtual ICollection<DebtorOrganizationRelation> DebtorOrganizationRelations { get; } =
            new List<DebtorOrganizationRelation>();

        public virtual Department? Department { get; set; }

        public virtual ICollection<DossierParty> DossierParties { get; } = new List<DossierParty>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();

        public virtual FiscalEntity? FiscalEntity { get; set; }

        public virtual GreenCardOffice? GreenCardOffice { get; set; }

        public virtual ICollection<InsurancePolicy> InsurancePolicyIpoChargedExpensesInvoiceRecipients { get; } =
            new List<InsurancePolicy>();

        public virtual ICollection<InsurancePolicy> InsurancePolicyIpoFeeInvoiceRecipients { get; } =
            new List<InsurancePolicy>();

        public virtual ICollection<InsurancePolicy> InsurancePolicyIpoOwnRiskInvoiceRecipients { get; } =
            new List<InsurancePolicy>();

        public virtual ICollection<InsurancePolicy> InsurancePolicyIpoVatdeductableInvoiceRecipients { get; } =
            new List<InsurancePolicy>();

        public virtual Insurer? Insurer { get; set; }

        public virtual InternationalAssistanceGroup? InternationalAssistanceGroup { get; set; }

        public virtual LeasingCompany? LeasingCompany { get; set; }

        public virtual LegalEntity? LegalEntity { get; set; }

        public virtual Mandate? Mandate { get; set; }

        public virtual ICollection<OrganizationAccount> OrganizationAccounts { get; } = new List<OrganizationAccount>();

        public virtual ICollection<OrganizationAddress> OrganizationAddresses { get; } =
            new List<OrganizationAddress>();

        public virtual ICollection<OrganizationApplication> OrganizationApplications { get; } =
            new List<OrganizationApplication>();

        public virtual ICollection<OrganizationCode> OrganizationCodes { get; } = new List<OrganizationCode>();

        public virtual ICollection<OrganizationContact> OrganizationContacts { get; } = new List<OrganizationContact>();

        public virtual ICollection<OrganizationCoverageProduct> OrganizationCoverageProducts { get; } =
            new List<OrganizationCoverageProduct>();

        public virtual ICollection<OrganizationCoverageProductsExtension>
            OrganizationCoverageProductsExtensionOcpeExternalCostInvoiceRecipients { get; } =
            new List<OrganizationCoverageProductsExtension>();

        public virtual ICollection<OrganizationCoverageProductsExtension>
            OrganizationCoverageProductsExtensionOcpeFeeInvoiceRecipients { get; } =
            new List<OrganizationCoverageProductsExtension>();

        public virtual OrganizationHierarchy? OrganizationHierarchyOh { get; set; }

        public virtual ICollection<OrganizationHierarchy> OrganizationHierarchyOhParentOus { get; } =
            new List<OrganizationHierarchy>();

        public virtual ICollection<OrganizationLabel> OrganizationLabels { get; } = new List<OrganizationLabel>();

        public virtual ICollection<OrganizationNote> OrganizationNotes { get; } = new List<OrganizationNote>();

        public virtual ICollection<OrganizationPaymentCondition> OrganizationPaymentConditions { get; } =
            new List<OrganizationPaymentCondition>();

        public virtual ICollection<OrganizationPaymentMethod> OrganizationPaymentMethods { get; } =
            new List<OrganizationPaymentMethod>();

        public virtual ICollection<OrganizationTaxCode> OrganizationTaxCodes { get; } = new List<OrganizationTaxCode>();

        public virtual ICollection<OrganizationUnitValidationStatusHistory> OrganizationUnitValidationStatusHistories
        {
            get;
        } = new List<OrganizationUnitValidationStatusHistory>();

        public virtual ICollection<OrganizationVatRegistration> OrganizationVatRegistrations { get; } =
            new List<OrganizationVatRegistration>();

        public virtual ICollection<OrganizationVatValidation> OrganizationVatValidations { get; } =
            new List<OrganizationVatValidation>();

        public virtual Address? OuAddress { get; set; }

        public virtual CollectionCode? OuCollectionCode { get; set; }

        public virtual HierarchyType? OuHierarchyType { get; set; }

        public virtual OrganizationGroup? OuOrganizationGroup { get; set; }

        public virtual OrganizationType? OuOrganizationType { get; set; }

        public virtual PostOfficeBox? OuPostOfficeBox { get; set; }

        public virtual Tenant? OuTenant { get; set; }

        public virtual Partner? Partner { get; set; }

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual Repairer? Repairer { get; set; }

        public virtual RoadAuthority? RoadAuthority { get; set; }

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual Supplier? Supplier { get; set; }

        public virtual Team? Team { get; set; }

        public virtual ICollection<TimeWindowList> TimeWindowLists { get; } = new List<TimeWindowList>();

        public virtual ICollection<WorkingOrderLine> WorkingOrderLines { get; } = new List<WorkingOrderLine>();
    }
}