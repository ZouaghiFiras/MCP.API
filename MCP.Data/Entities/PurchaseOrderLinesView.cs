namespace CED.Data.Entities
{
    public class PurchaseOrderLinesView
    {
        public Guid Id { get; set; }

        public Guid PurchaseOrderId { get; set; }

        public string PurchaseOrderNumber { get; set; } = null!;

        public int LineNumber { get; set; }

        public double Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Discount { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxBase { get; set; }

        public double TaxRate { get; set; }

        public string? TaxCode { get; set; }

        public decimal? TaxAmount { get; set; }

        public string? TaxCountryCode { get; set; }

        public decimal? NetAmount { get; set; }

        public bool IsTaxBeforeDiscount { get; set; }

        public bool TaxExempted { get; set; }

        public bool TaxReversedCharge { get; set; }

        public bool TaxImport { get; set; }

        public Guid SupplierServiceId { get; set; }

        public Guid SupplierId { get; set; }

        public string SupplierCode { get; set; } = null!;

        public string SupplierName { get; set; } = null!;

        public string? SupplierVatNumber { get; set; }

        public string? SupplierCity { get; set; }

        public string? SupplierCountryCode { get; set; }

        public Guid ServiceId { get; set; }

        public string ServiceCode { get; set; } = null!;

        public string? ServiceShortName { get; set; }

        public string ServiceLongName { get; set; } = null!;

        public bool ServiceInactive { get; set; }

        public Guid? MainServiceGroupId { get; set; }

        public string? MainServiceGroupCode { get; set; }

        public string? MainServiceGroupShortName { get; set; }

        public string? MainServiceGroupLongName { get; set; }

        public Guid? SubServiceGroupId { get; set; }

        public string? SubServiceGroupCode { get; set; }

        public string? SubServiceGroupShortName { get; set; }

        public string? SubServiceGroupLongName { get; set; }

        public string? LineOrderNumber { get; set; }

        public Guid? InvolvedPartyId { get; set; }

        public string? Notes { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public string? AssistancePlanNumber { get; set; }

        public bool IsCostOfSales { get; set; }

        public string? VehicleLicensePlate { get; set; }

        public string? VehicleLicenseCountryCode { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? SubContractorId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? WorkingOrderId { get; set; }

        public string? WorkingOrderNumber { get; set; }

        public Guid WorkingOrderLineCostId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}