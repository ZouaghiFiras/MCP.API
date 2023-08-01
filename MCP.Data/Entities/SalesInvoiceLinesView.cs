namespace CED.Data.Entities
{
    public class SalesInvoiceLinesView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public Guid SalesInvoiceId { get; set; }

        public int LineNumber { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public double Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Discount { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal? TaxBase { get; set; }

        public double TaxRate { get; set; }

        public string? TaxCode { get; set; }

        public decimal TaxAmount { get; set; }

        public bool TaxExempted { get; set; }

        public bool TaxReversedCharge { get; set; }

        public bool TaxImport { get; set; }

        public string? TaxCountryCode { get; set; }

        public decimal NetAmount { get; set; }

        public bool IsTaxBeforeDiscount { get; set; }

        public string? JournalId { get; set; }

        public string? JouralName { get; set; }

        public bool IsCredit { get; set; }

        public string? DebitLineNumber { get; set; }

        public bool IsFee { get; set; }

        public decimal? FeeBase { get; set; }

        public decimal? FeeRate { get; set; }

        public decimal? MinimumFee { get; set; }

        public decimal? MaximumFee { get; set; }

        public decimal? AdditionalCharges { get; set; }

        public Guid? ProductId { get; set; }

        public string? AssistancePlanNumber { get; set; }

        public string? WorkActivityName { get; set; }

        public string? ActivityOptionName { get; set; }

        public string? TranslatedProductName { get; set; }

        public string? TranslatedWorkActivityName { get; set; }

        public string? TranslatedActivityOptionName { get; set; }

        public Guid? ClaimReserveId { get; set; }

        public string? ClaimReserveNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}