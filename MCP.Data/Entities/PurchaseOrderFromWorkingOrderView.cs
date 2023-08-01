namespace CED.Data.Entities
{
    public class PurchaseOrderFromWorkingOrderView
    {
        public string? CurrentStatus { get; set; }

        public bool? IsResultingInPurchaseOrder { get; set; }

        public bool? IsCredit { get; set; }

        public bool? IsPrinted { get; set; }

        public bool? IsImported { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? DossierObjectId { get; set; }

        public Guid? DepartmentId { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public Guid? SupplierId { get; set; }

        public Guid WorkingOrderLineId { get; set; }

        public Guid WorkingOrder { get; set; }

        public Guid? DeliveryAddressId { get; set; }

        public Guid? InvoiceToPayorId { get; set; }

        public Guid? InvoiceToPayorAddressId { get; set; }

        public string Description { get; set; } = null!;

        public Guid? SubContractorId { get; set; }

        public string? YourReference { get; set; }

        public DateTime? ExpectedDeliveryDate { get; set; }

        public string? CultureCode { get; set; }

        public Guid? DossierPartyId { get; set; }

        public int? DocumentId { get; set; }

        public Guid? WorkingOrderLineCostId { get; set; }

        public double? Quantity { get; set; }

        public Guid? ServiceId { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Discount { get; set; }

        public decimal? NetAmount { get; set; }

        public bool? IsCostOfSales { get; set; }

        public decimal? CostOfSalesAmount { get; set; }

        public decimal? MaxCostOfSalesAmount { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public double? TaxRate { get; set; }

        public bool? IsTaxExempted { get; set; }

        public decimal? TaxExemptedAmount { get; set; }

        public bool? IsTaxReversedChargeAmount { get; set; }

        public decimal? TaxReversedChargeAmount { get; set; }

        public bool? TaxImport { get; set; }

        public decimal? TaxImportAmount { get; set; }

        public decimal? TaxBase { get; set; }

        public decimal? MaxGrossAmount { get; set; }

        public decimal? MaxTaxAmount { get; set; }

        public decimal? MaxNetAmout { get; set; }

        public string? TaxCountryCode { get; set; }

        public string SupplierServiceId { get; set; } = null!;

        public bool? IsTaxBeforeDiscount { get; set; }

        public string? UnitOfMeasureId { get; set; }

        public decimal? MaxNetAmount { get; set; }

        public string? TaxCode { get; set; }
    }
}