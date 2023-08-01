namespace CED.Data.Entities
{
    public class Service
    {
        public Guid ItmId { get; set; }

        public byte[] ItmTimeStamp { get; set; } = null!;

        public string ItmCode { get; set; } = null!;

        public string? ItmShortName { get; set; }

        public string ItmLongName { get; set; } = null!;

        public Guid? ItmMainServiceGroupId { get; set; }

        public Guid? ItmSubServiceGroupId { get; set; }

        public string? ItmPurchaseTaxCodeId { get; set; }

        public string? ItmTaxCategoryId { get; set; }

        public bool ItmIsTransitoryItem { get; set; }

        public bool? ItmForeignTaxApplicable { get; set; }

        public Guid? ItmProductId { get; set; }

        public bool ItmInactive { get; set; }

        public Guid? ItmLocalizableEntryId { get; set; }

        public DateTime ItmCreatedDate { get; set; }

        public string? ItmCreatedBy { get; set; }

        public DateTime ItmLastModifiedDate { get; set; }

        public string? ItmLastModifiedBy { get; set; }

        public bool? ItmIsLoweredVatapplicable { get; set; }

        public bool? ItmIsLoweredVatpossible { get; set; }

        public Guid? ItmServiceTypeId { get; set; }

        public string? ItmUnitOfMeasureId { get; set; }

        public virtual ICollection<AssistancePlanLine> AssistancePlanLines { get; } = new List<AssistancePlanLine>();

        public virtual ClaimReserveService? ClaimReserveService { get; set; }

        public virtual ICollection<CostFeeSettlementLine> CostFeeSettlementLines { get; } =
            new List<CostFeeSettlementLine>();

        public virtual ICollection<CostSettlementLine> CostSettlementLines { get; } = new List<CostSettlementLine>();

        public virtual LocalizableEntry? ItmLocalizableEntry { get; set; }

        public virtual ServiceGroup? ItmMainServiceGroup { get; set; }

        public virtual Product? ItmProduct { get; set; }

        public virtual ServiceGroup? ItmSubServiceGroup { get; set; }

        public virtual ICollection<PurchaseBacklogLine> PurchaseBacklogLines { get; } = new List<PurchaseBacklogLine>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<SalesSettlementLine> SalesSettlementLines { get; } = new List<SalesSettlementLine>();

        public virtual ICollection<ServiceApplication> ServiceApplications { get; } = new List<ServiceApplication>();

        public virtual ICollection<ServiceCode> ServiceCodes { get; } = new List<ServiceCode>();

        public virtual ICollection<ServiceHierarchy> ServiceHierarchySehChildren { get; } =
            new List<ServiceHierarchy>();

        public virtual ICollection<ServiceHierarchy> ServiceHierarchySehParents { get; } = new List<ServiceHierarchy>();

        public virtual ICollection<ServiceTaxRate> ServiceTaxRates { get; } = new List<ServiceTaxRate>();

        public virtual ICollection<SupplierService> SupplierServices { get; } = new List<SupplierService>();
    }
}