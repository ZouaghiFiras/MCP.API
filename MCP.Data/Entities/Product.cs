namespace CED.Data.Entities
{
    public class Product
    {
        public Guid PrdId { get; set; }

        public byte[] PrdTimeStamp { get; set; } = null!;

        public string PrdCode { get; set; } = null!;

        public string? PrdShortName { get; set; }

        public string PrdLongName { get; set; } = null!;

        public bool PrdInactive { get; set; }

        public Guid PrdProductGroupId { get; set; }

        public Guid? PrdDepartmentId { get; set; }

        public string? PrdSalesLedgerAccount { get; set; }

        public string? PrdPurchaseLedgerAccount { get; set; }

        public string? PrdSalesTaxCodeId { get; set; }

        public string? PrdPurchaseTaxCodeId { get; set; }

        public string? PrdConsolidationCreditorNumber { get; set; }

        public string? PrdLedgerAccount { get; set; }

        public bool PrdPurchaseTaxIncluded { get; set; }

        public bool PrdPurchaseTaxApplicable { get; set; }

        public Guid? PrdLocalizableEntryId { get; set; }

        public bool PrdIsTransitoryItem { get; set; }

        public DateTime PrdCreatedDate { get; set; }

        public string? PrdCreatedBy { get; set; }

        public DateTime PrdLastModifiedDate { get; set; }

        public string? PrdLastModifiedBy { get; set; }

        public Guid? PrdProductTypeId { get; set; }

        public Guid? PrdProductClassificationId { get; set; }

        public bool? PrdIsGeneric { get; set; }

        public DateTime? PrdEffectiveDate { get; set; }

        public DateTime? PrdTerminationDate { get; set; }

        public virtual ICollection<AppointmentTimeSlot> AppointmentTimeSlots { get; } = new List<AppointmentTimeSlot>();

        public virtual ICollection<BookingDimension> BookingDimensions { get; } = new List<BookingDimension>();

        public virtual ICollection<DebtorOrganizationRelation> DebtorOrganizationRelations { get; } =
            new List<DebtorOrganizationRelation>();

        public virtual ICollection<DebtorOrganizationSummaryStatement> DebtorOrganizationSummaryStatements { get; } =
            new List<DebtorOrganizationSummaryStatement>();

        public virtual ICollection<DossierAssignment> DossierAssignments { get; } = new List<DossierAssignment>();

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();

        public virtual ICollection<FeeSettlementLine> FeeSettlementLines { get; } = new List<FeeSettlementLine>();

        public virtual ICollection<FeeSettlementReportingFormOption> FeeSettlementReportingFormOptions { get; } =
            new List<FeeSettlementReportingFormOption>();

        public virtual ICollection<KeyPerformanceIndicatorTrigger> KeyPerformanceIndicatorTriggers { get; } =
            new List<KeyPerformanceIndicatorTrigger>();

        public virtual ICollection<ModelProduct> ModelProducts { get; } = new List<ModelProduct>();

        public virtual Department? PrdDepartment { get; set; }

        public virtual LocalizableEntry? PrdLocalizableEntry { get; set; }

        public virtual ProductClassification? PrdProductClassification { get; set; }

        public virtual ProductGroup PrdProductGroup { get; set; } = null!;

        public virtual ProductType? PrdProductType { get; set; }

        public virtual ICollection<ProductActivityOption> ProductActivityOptions { get; } =
            new List<ProductActivityOption>();

        public virtual ICollection<ProductApplication> ProductApplications { get; } = new List<ProductApplication>();

        public virtual ICollection<ProductDamageReason> ProductDamageReasons { get; } = new List<ProductDamageReason>();

        public virtual ICollection<ProductDeliveryMethod> ProductDeliveryMethods { get; } =
            new List<ProductDeliveryMethod>();

        public virtual ICollection<ProductDepartment> ProductDepartments { get; } = new List<ProductDepartment>();

        public virtual ICollection<ProductExclusion> ProductExclusions { get; } = new List<ProductExclusion>();

        public virtual ICollection<ProductHierarchy> ProductHierarchyPrhChildProducts { get; } =
            new List<ProductHierarchy>();

        public virtual ICollection<ProductHierarchy> ProductHierarchyPrhParentProducts { get; } =
            new List<ProductHierarchy>();

        public virtual ICollection<ProductInsuranceCoverage> ProductInsuranceCoverages { get; } =
            new List<ProductInsuranceCoverage>();

        public virtual ICollection<ProductInsuranceObject> ProductInsuranceObjects { get; } =
            new List<ProductInsuranceObject>();

        public virtual ICollection<ProductWorkActivity> ProductWorkActivities { get; } =
            new List<ProductWorkActivity>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesLedgerSetting> SalesLedgerSettings { get; } = new List<SalesLedgerSetting>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual ICollection<SalesSettlementLine> SalesSettlementLines { get; } = new List<SalesSettlementLine>();

        public virtual ICollection<Service> Services { get; } = new List<Service>();

        public virtual ICollection<SubContract> SubContracts { get; } = new List<SubContract>();

        public virtual ICollection<WorkingOrderLineCoverage> WorkingOrderLineCoverages { get; } =
            new List<WorkingOrderLineCoverage>();
    }
}