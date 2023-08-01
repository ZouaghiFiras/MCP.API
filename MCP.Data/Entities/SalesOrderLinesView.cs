namespace CED.Data.Entities
{
    public class SalesOrderLinesView
    {
        public Guid Id { get; set; }

        public Guid SalesOrderId { get; set; }

        public int LineNumber { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public Guid? ProductId { get; set; }

        public string? ProductName { get; set; }

        public double Quantity { get; set; }

        public string? UnitOfMeasureId { get; set; }

        public string? UnitOfMeasureName { get; set; }

        public decimal? UnitPrice { get; set; }

        public string? CurrencyCode { get; set; }

        public double? ExchangeRate { get; set; }

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

        public bool IsCredit { get; set; }

        public string? DebitLineNumber { get; set; }

        public Guid? InvolvedPartyId { get; set; }

        public string? InvolvedPartyName { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? AssignmentNumber { get; set; }

        public Guid? DossierPartyId { get; set; }

        public string? DossierPartyName { get; set; }

        public bool IsFee { get; set; }

        public decimal? FeeBase { get; set; }

        public decimal? FeeRate { get; set; }

        public decimal? MinimumFee { get; set; }

        public decimal? MaximumFee { get; set; }

        public decimal? FixedFee { get; set; }

        public decimal? HourlyFee { get; set; }

        public Guid? FeeAgreementId { get; set; }

        public string? FeeAgreementName { get; set; }

        public decimal? AdditionalCharges { get; set; }

        public bool IsVoided { get; set; }

        public string? JournalId { get; set; }

        public Guid? WorkActivitityId { get; set; }

        public string? WorkActivityName { get; set; }

        public string? WorkActivityCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}