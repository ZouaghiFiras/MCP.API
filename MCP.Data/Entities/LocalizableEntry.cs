namespace CED.Data.Entities
{
    public class LocalizableEntry
    {
        public Guid LleId { get; set; }

        public byte[] LleTimeStamp { get; set; } = null!;

        public Guid LleLocalizableTypeId { get; set; }

        public DateTime LleCreatedDate { get; set; }

        public string? LleCreatedBy { get; set; }

        public DateTime LleLastModifiedDate { get; set; }

        public string? LleLastModifiedBy { get; set; }

        public virtual ICollection<ActivityExecution> ActivityExecutions { get; } = new List<ActivityExecution>();

        public virtual ICollection<ActivityOption> ActivityOptions { get; } = new List<ActivityOption>();

        public virtual ICollection<AddressType> AddressTypes { get; } = new List<AddressType>();

        public virtual ICollection<Application> Applications { get; } = new List<Application>();

        public virtual ICollection<AssistanceLocationType> AssistanceLocationTypes { get; } =
            new List<AssistanceLocationType>();

        public virtual ICollection<AssistancePlanStatus> AssistancePlanStatuses { get; } =
            new List<AssistancePlanStatus>();

        public virtual ICollection<AssistancePlanType> AssistancePlanTypes { get; } = new List<AssistancePlanType>();

        public virtual ICollection<AuthorizationRoleType> AuthorizationRoleTypes { get; } =
            new List<AuthorizationRoleType>();

        public virtual ICollection<BankStatementStatus> BankStatementStatuses { get; } =
            new List<BankStatementStatus>();

        public virtual ICollection<Brand> Brands { get; } = new List<Brand>();

        public virtual ICollection<Chain> Chains { get; } = new List<Chain>();

        public virtual ICollection<ClaimReserveClassification> ClaimReserveClassifications { get; } =
            new List<ClaimReserveClassification>();

        public virtual ICollection<ClaimReserveStatus> ClaimReserveStatuses { get; } = new List<ClaimReserveStatus>();

        public virtual ICollection<ClaimReserveType> ClaimReserveTypes { get; } = new List<ClaimReserveType>();

        public virtual ICollection<CollectionCode> CollectionCodes { get; } = new List<CollectionCode>();

        public virtual ICollection<Color> Colors { get; } = new List<Color>();

        public virtual ICollection<CommunicationType> CommunicationTypes { get; } = new List<CommunicationType>();

        public virtual ICollection<ContactPersonType> ContactPersonTypes { get; } = new List<ContactPersonType>();

        public virtual ICollection<ContactType> ContactTypes { get; } = new List<ContactType>();

        public virtual ICollection<CorrespondenceMethod> CorrespondenceMethods { get; } =
            new List<CorrespondenceMethod>();

        public virtual ICollection<CostAgreementType> CostAgreementTypes { get; } = new List<CostAgreementType>();

        public virtual ICollection<CostCenter> CostCenters { get; } = new List<CostCenter>();

        public virtual ICollection<CostType> CostTypes { get; } = new List<CostType>();

        public virtual ICollection<CostUnit> CostUnits { get; } = new List<CostUnit>();

        public virtual ICollection<Country> Countries { get; } = new List<Country>();

        public virtual ICollection<CoverageProductType> CoverageProductTypes { get; } = new List<CoverageProductType>();

        public virtual ICollection<CoverageProduct> CoverageProducts { get; } = new List<CoverageProduct>();

        public virtual ICollection<CreditorStatus> CreditorStatuses { get; } = new List<CreditorStatus>();

        public virtual ICollection<Currency> Currencies { get; } = new List<Currency>();

        public virtual ICollection<DamageLocation> DamageLocations { get; } = new List<DamageLocation>();

        public virtual ICollection<DamageReasonType> DamageReasonTypes { get; } = new List<DamageReasonType>();

        public virtual ICollection<DamageReason> DamageReasons { get; } = new List<DamageReason>();

        public virtual ICollection<DebtorStatus> DebtorStatuses { get; } = new List<DebtorStatus>();

        public virtual ICollection<DeliveryMethod> DeliveryMethods { get; } = new List<DeliveryMethod>();

        public virtual ICollection<DocumentType> DocumentTypes { get; } = new List<DocumentType>();

        public virtual ICollection<DossierAssignmentEmployeeType> DossierAssignmentEmployeeTypes { get; } =
            new List<DossierAssignmentEmployeeType>();

        public virtual ICollection<DossierAssignmentOperationalStatusType> DossierAssignmentOperationalStatusTypes
        {
            get;
        } = new List<DossierAssignmentOperationalStatusType>();

        public virtual ICollection<DossierAssignmentOperationalStatus> DossierAssignmentOperationalStatuses { get; } =
            new List<DossierAssignmentOperationalStatus>();

        public virtual ICollection<DossierAssignmentStatusType> DossierAssignmentStatusTypes { get; } =
            new List<DossierAssignmentStatusType>();

        public virtual ICollection<DossierAssignmentStatus> DossierAssignmentStatuses { get; } =
            new List<DossierAssignmentStatus>();

        public virtual ICollection<DossierAssignmentType> DossierAssignmentTypes { get; } =
            new List<DossierAssignmentType>();

        public virtual ICollection<DossierCostType> DossierCostTypes { get; } = new List<DossierCostType>();

        public virtual ICollection<DossierOperationalStatusType> DossierOperationalStatusTypes { get; } =
            new List<DossierOperationalStatusType>();

        public virtual ICollection<DossierOperationalStatus> DossierOperationalStatuses { get; } =
            new List<DossierOperationalStatus>();

        public virtual ICollection<DossierStatusType> DossierStatusTypes { get; } = new List<DossierStatusType>();

        public virtual ICollection<DossierStatus> DossierStatuses { get; } = new List<DossierStatus>();

        public virtual ICollection<ExchangeRateType> ExchangeRateTypes { get; } = new List<ExchangeRateType>();

        public virtual ICollection<ExternalMaterial> ExternalMaterials { get; } = new List<ExternalMaterial>();

        public virtual ICollection<FeeAgreementType> FeeAgreementTypes { get; } = new List<FeeAgreementType>();

        public virtual ICollection<FeeSettlementStatusType> FeeSettlementStatusTypes { get; } =
            new List<FeeSettlementStatusType>();

        public virtual ICollection<FeeSettlementStatus> FeeSettlementStatuses { get; } =
            new List<FeeSettlementStatus>();

        public virtual ICollection<FuelType> FuelTypes { get; } = new List<FuelType>();

        public virtual ICollection<Fuel> Fuels { get; } = new List<Fuel>();

        public virtual ICollection<FundingsPaymentStatus> FundingsPaymentStatuses { get; } =
            new List<FundingsPaymentStatus>();

        public virtual ICollection<Gender> Genders { get; } = new List<Gender>();

        public virtual ICollection<GeneralLedger> GeneralLedgers { get; } = new List<GeneralLedger>();

        public virtual ICollection<HandlingType> HandlingTypes { get; } = new List<HandlingType>();

        public virtual ICollection<HierarchyType> HierarchyTypes { get; } = new List<HierarchyType>();

        public virtual ICollection<InputMethod> InputMethods { get; } = new List<InputMethod>();

        public virtual ICollection<InsuranceCoverageType> InsuranceCoverageTypes { get; } =
            new List<InsuranceCoverageType>();

        public virtual ICollection<InsuranceCoverage> InsuranceCoverages { get; } = new List<InsuranceCoverage>();

        public virtual ICollection<InsuranceObjectType> InsuranceObjectTypes { get; } = new List<InsuranceObjectType>();

        public virtual ICollection<InsuranceObject> InsuranceObjects { get; } = new List<InsuranceObject>();

        public virtual ICollection<InsuranceProductType> InsuranceProductTypes { get; } =
            new List<InsuranceProductType>();

        public virtual ICollection<InternationalAssistanceGroupType> InternationalAssistanceGroupTypes { get; } =
            new List<InternationalAssistanceGroupType>();

        public virtual ICollection<InvoiceAttributeType> InvoiceAttributeTypes { get; } =
            new List<InvoiceAttributeType>();

        public virtual ICollection<InvoiceDeliveryMethodType> InvoiceDeliveryMethodTypes { get; } =
            new List<InvoiceDeliveryMethodType>();

        public virtual ICollection<InvoiceDeliveryMethod> InvoiceDeliveryMethods { get; } =
            new List<InvoiceDeliveryMethod>();

        public virtual ICollection<InvoicePriorityType> InvoicePriorityTypes { get; } = new List<InvoicePriorityType>();

        public virtual ICollection<InvoiceRuleType> InvoiceRuleTypes { get; } = new List<InvoiceRuleType>();

        public virtual ICollection<InvoiceType> InvoiceTypes { get; } = new List<InvoiceType>();

        public virtual ICollection<JournalEntryStatus> JournalEntryStatuses { get; } = new List<JournalEntryStatus>();

        public virtual ICollection<JournalSettingType> JournalSettingTypes { get; } = new List<JournalSettingType>();

        public virtual ICollection<JournalType> JournalTypes { get; } = new List<JournalType>();

        public virtual ICollection<Journal> Journals { get; } = new List<Journal>();

        public virtual ICollection<LiabilityStatus> LiabilityStatuses { get; } = new List<LiabilityStatus>();

        public virtual LocalizableType LleLocalizableType { get; set; } = null!;

        public virtual ICollection<LocalizedEntry> LocalizedEntries { get; } = new List<LocalizedEntry>();

        public virtual ICollection<LocationType> LocationTypes { get; } = new List<LocationType>();

        public virtual ICollection<LogHistoryType> LogHistoryTypes { get; } = new List<LogHistoryType>();

        public virtual ICollection<MeterReadingDetermined> MeterReadingDetermineds { get; } =
            new List<MeterReadingDetermined>();

        public virtual ICollection<MeterReadingQuantity> MeterReadingQuantities { get; } =
            new List<MeterReadingQuantity>();

        public virtual ICollection<ModelSpecification> ModelSpecifications { get; } = new List<ModelSpecification>();

        public virtual ICollection<Model> Models { get; } = new List<Model>();

        public virtual ICollection<NoteType> NoteTypes { get; } = new List<NoteType>();

        public virtual ICollection<ObjectClassification> ObjectClassifications { get; } =
            new List<ObjectClassification>();

        public virtual ICollection<OrganizationCodeType> OrganizationCodeTypes { get; } =
            new List<OrganizationCodeType>();

        public virtual ICollection<OrganizationGroup> OrganizationGroups { get; } = new List<OrganizationGroup>();

        public virtual ICollection<OrganizationLabelType> OrganizationLabelTypes { get; } =
            new List<OrganizationLabelType>();

        public virtual ICollection<OrganizationType> OrganizationTypes { get; } = new List<OrganizationType>();

        public virtual ICollection<PaintType> PaintTypes { get; } = new List<PaintType>();

        public virtual ICollection<PaymentMethod> PaymentMethods { get; } = new List<PaymentMethod>();

        public virtual ICollection<PaymentStatus> PaymentStatuses { get; } = new List<PaymentStatus>();

        public virtual ICollection<PayorType> PayorTypes { get; } = new List<PayorType>();

        public virtual ICollection<PostHandlingPriority> PostHandlingPriorities { get; } =
            new List<PostHandlingPriority>();

        public virtual ICollection<PostStatus> PostStatuses { get; } = new List<PostStatus>();

        public virtual ICollection<ProductClassification> ProductClassifications { get; } =
            new List<ProductClassification>();

        public virtual ICollection<ProductGroup> ProductGroups { get; } = new List<ProductGroup>();

        public virtual ICollection<Product> Products { get; } = new List<Product>();

        public virtual ICollection<PurchaseBacklogSourceType> PurchaseBacklogSourceTypes { get; } =
            new List<PurchaseBacklogSourceType>();

        public virtual ICollection<PurchaseBacklogStatus> PurchaseBacklogStatuses { get; } =
            new List<PurchaseBacklogStatus>();

        public virtual ICollection<PurchaseInvoiceStatus> PurchaseInvoiceStatuses { get; } =
            new List<PurchaseInvoiceStatus>();

        public virtual ICollection<PurchaseOrderStatus> PurchaseOrderStatuses { get; } =
            new List<PurchaseOrderStatus>();

        public virtual ICollection<PurchasePaymentStatus> PurchasePaymentStatuses { get; } =
            new List<PurchasePaymentStatus>();

        public virtual ICollection<ReconcilliationActionType> ReconcilliationActionTypes { get; } =
            new List<ReconcilliationActionType>();

        public virtual ICollection<ReconcilliationRefundType> ReconcilliationRefundTypes { get; } =
            new List<ReconcilliationRefundType>();

        public virtual ICollection<RecoveryPaymentStatus> RecoveryPaymentStatuses { get; } =
            new List<RecoveryPaymentStatus>();

        public virtual ICollection<RecoveryStatementStatus> RecoveryStatementStatuses { get; } =
            new List<RecoveryStatementStatus>();

        public virtual ICollection<ReportingForm> ReportingForms { get; } = new List<ReportingForm>();

        public virtual ICollection<RoadAuthorityCode1> RoadAuthorityCode1s { get; } = new List<RoadAuthorityCode1>();

        public virtual ICollection<RoadAuthorityType> RoadAuthorityTypes { get; } = new List<RoadAuthorityType>();

        public virtual ICollection<RoadDirection> RoadDirections { get; } = new List<RoadDirection>();

        public virtual ICollection<RoadSection1> RoadSection1s { get; } = new List<RoadSection1>();

        public virtual ICollection<RoadSide> RoadSides { get; } = new List<RoadSide>();

        public virtual ICollection<RoadType> RoadTypes { get; } = new List<RoadType>();

        public virtual ICollection<RoleCode1> RoleCode1s { get; } = new List<RoleCode1>();

        public virtual ICollection<RoleCode> RoleCodes { get; } = new List<RoleCode>();

        public virtual ICollection<RoofCovering> RoofCoverings { get; } = new List<RoofCovering>();

        public virtual ICollection<SalesAgreementType> SalesAgreementTypes { get; } = new List<SalesAgreementType>();

        public virtual ICollection<SalesCollectionStatus> SalesCollectionStatuses { get; } =
            new List<SalesCollectionStatus>();

        public virtual ICollection<SalesInvoiceStatus> SalesInvoiceStatuses { get; } = new List<SalesInvoiceStatus>();

        public virtual ICollection<SalesOrderStatus> SalesOrderStatuses { get; } = new List<SalesOrderStatus>();

        public virtual ICollection<SalesOrderType> SalesOrderTypes { get; } = new List<SalesOrderType>();

        public virtual ICollection<SalesPaymentStatus> SalesPaymentStatuses { get; } = new List<SalesPaymentStatus>();

        public virtual ICollection<Salutation> SalutationSalSalutationLocalizableEntries { get; } =
            new List<Salutation>();

        public virtual ICollection<Salutation> SalutationSalTitleLocalizableEntries { get; } = new List<Salutation>();

        public virtual ICollection<ServiceCodeType> ServiceCodeTypes { get; } = new List<ServiceCodeType>();

        public virtual ICollection<ServiceGroup> ServiceGroups { get; } = new List<ServiceGroup>();

        public virtual ICollection<Service> Services { get; } = new List<Service>();

        public virtual ICollection<Skill> Skills { get; } = new List<Skill>();

        public virtual ICollection<Specification> Specifications { get; } = new List<Specification>();

        public virtual ICollection<Status> Statuses { get; } = new List<Status>();

        public virtual ICollection<SummaryStatementCreationMethod> SummaryStatementCreationMethods { get; } =
            new List<SummaryStatementCreationMethod>();

        public virtual ICollection<TaxCategory> TaxCategories { get; } = new List<TaxCategory>();

        public virtual ICollection<TaxType> TaxTypes { get; } = new List<TaxType>();

        public virtual ICollection<Transmission> Transmissions { get; } = new List<Transmission>();

        public virtual ICollection<UnitOfMeasureType> UnitOfMeasureTypes { get; } = new List<UnitOfMeasureType>();

        public virtual ICollection<UnitOfMeasure> UnitOfMeasures { get; } = new List<UnitOfMeasure>();

        public virtual ICollection<ValuationPrinciple> ValuationPrinciples { get; } = new List<ValuationPrinciple>();

        public virtual ICollection<VatNumberTaxCode> VatNumberTaxCodes { get; } = new List<VatNumberTaxCode>();

        public virtual ICollection<VisitInformationStatusType> VisitInformationStatusTypes { get; } =
            new List<VisitInformationStatusType>();

        public virtual ICollection<VisitInformationStatus> VisitInformationStatuses { get; } =
            new List<VisitInformationStatus>();

        public virtual ICollection<WorkActivity> WorkActivities { get; } = new List<WorkActivity>();

        public virtual ICollection<WorkingOrderLineCostType> WorkingOrderLineCostTypes { get; } =
            new List<WorkingOrderLineCostType>();

        public virtual ICollection<WorkingOrderLineOperationalStatusType> WorkingOrderLineOperationalStatusTypes
        {
            get;
        } = new List<WorkingOrderLineOperationalStatusType>();

        public virtual ICollection<WorkingOrderLineOperationalStatus> WorkingOrderLineOperationalStatuses { get; } =
            new List<WorkingOrderLineOperationalStatus>();

        public virtual ICollection<WorkingOrderLineStatusType> WorkingOrderLineStatusTypes { get; } =
            new List<WorkingOrderLineStatusType>();

        public virtual ICollection<WorkingOrderLineStatus> WorkingOrderLineStatuses { get; } =
            new List<WorkingOrderLineStatus>();

        public virtual ICollection<WorkingOrderStatusType> WorkingOrderStatusTypes { get; } =
            new List<WorkingOrderStatusType>();

        public virtual ICollection<WorkingOrderStatus> WorkingOrderStatuses { get; } = new List<WorkingOrderStatus>();
    }
}