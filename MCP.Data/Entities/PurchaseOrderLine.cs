namespace CED.Data.Entities
{
    public class PurchaseOrderLine
    {
        public Guid PolId { get; set; }

        public byte[] PolTimeStamp { get; set; } = null!;

        public Guid PolPurchaseOrderId { get; set; }

        public Guid PolWorkingOrderLineCostId { get; set; }

        public int PolLineNumber { get; set; }

        public double PolQuantity { get; set; }

        public string? PolUnitOfMeasureId { get; set; }

        public decimal? PolUnitPrice { get; set; }

        public decimal? PolDiscount { get; set; }

        public decimal? PolGrossAmount { get; set; }

        public decimal? PolTaxBase { get; set; }

        public double PolTaxRate { get; set; }

        public string? PolTaxCode { get; set; }

        public decimal? PolTaxAmount { get; set; }

        public decimal? PolNetAmount { get; set; }

        public bool PolIsTaxBeforeDiscount { get; set; }

        public bool PolTaxExempted { get; set; }

        public bool PolTaxReversedCharge { get; set; }

        public bool PolTaxImport { get; set; }

        public Guid PolSupplierServiceId { get; set; }

        public string? PolLineOrderNumber { get; set; }

        public Guid? PolInvolvedPartyId { get; set; }

        public bool PolIsCostOfSales { get; set; }

        public decimal? PolCostOfSalesAmount { get; set; }

        public decimal? PolMaxCostOfSalesAmount { get; set; }

        public string? PolNotes { get; set; }

        public decimal? PolMaxGrossAmount { get; set; }

        public decimal? PolMaxTaxAmount { get; set; }

        public decimal? PolMaxNetAmount { get; set; }

        public string? PolTaxCountryCode { get; set; }

        public DateTime PolCreatedDate { get; set; }

        public string? PolCreatedBy { get; set; }

        public DateTime PolLastModifiedDate { get; set; }

        public string? PolLastModifiedBy { get; set; }

        public decimal? PolChargeableAmount { get; set; }

        public decimal? PolMaxChargeableAmount { get; set; }

        public virtual PurchaseOrder PolPurchaseOrder { get; set; } = null!;

        public virtual SupplierService PolSupplierService { get; set; } = null!;

        public virtual UnitOfMeasure? PolUnitOfMeasure { get; set; }

        public virtual WorkingOrderLineCost PolWorkingOrderLineCost { get; set; } = null!;

        public virtual ICollection<PurchaseInvoiceToOrderMapping> PurchaseInvoiceToOrderMappings { get; } =
            new List<PurchaseInvoiceToOrderMapping>();

        public virtual ICollection<PurchaseOrderReceiptMapping> PurchaseOrderReceiptMappings { get; } =
            new List<PurchaseOrderReceiptMapping>();
    }
}