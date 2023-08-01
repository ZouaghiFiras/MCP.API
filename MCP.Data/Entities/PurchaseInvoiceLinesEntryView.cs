﻿namespace CED.Data.Entities
{
    public class PurchaseInvoiceLinesEntryView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public Guid PurchaseInvoiceId { get; set; }

        public int LineNumber { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int? DeliveryWeek { get; set; }

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public Guid? ServiceId { get; set; }

        public string? MainProductGroupCode { get; set; }

        public string? MainProductGroupName { get; set; }

        public string? SubProductGroupCode { get; set; }

        public string? SubProductGroupName { get; set; }

        public double Quantity { get; set; }

        public string? UnitOfMeasureId { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Discount { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal? TaxBase { get; set; }

        public double TaxRate { get; set; }

        public string? TaxCode { get; set; }

        public decimal TaxAmount { get; set; }

        public string? TaxCountryCode { get; set; }

        public decimal NetAmount { get; set; }

        public bool IsTaxBeforeDiscount { get; set; }

        public string? LedgerAccount { get; set; }

        public Guid? CostCenterId { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostCenterName { get; set; }

        public Guid? CostUnitId { get; set; }

        public string? CostUnitCode { get; set; }

        public string? CostUnitName { get; set; }

        public bool IsCredit { get; set; }

        public string? DebitLineNumber { get; set; }

        public string? OurReference { get; set; }

        public bool TaxExempted { get; set; }

        public bool TaxReversedCharge { get; set; }

        public bool TaxImport { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? DossierPartyId { get; set; }

        public string? JournalId { get; set; }

        public bool? HasCostOfSales { get; set; }

        public bool? IsCostOfSales { get; set; }

        public string? AssistancePlanNumbers { get; set; }

        public string? AssistancePlanNumbersFromMapping { get; set; }

        public string? WorkingOrderNumbers { get; set; }

        public string? WorkingOrderNumbersFromMapping { get; set; }

        public string? PurchaseOrderNumbers { get; set; }

        public decimal? ConvertedGrossAmount { get; set; }

        public decimal? ConvertedTaxAmount { get; set; }

        public decimal? ConvertedNetAmount { get; set; }

        public decimal? ConvertedUnitPrice { get; set; }

        public double? ConvertedTaxRate { get; set; }

        public string? ConvertedTaxCountryCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}