namespace CED.Data.Entities
{
    public class CostSettlementLinesView
    {
        public Guid Id { get; set; }

        public int LineNumber { get; set; }

        public Guid ServiceId { get; set; }

        public Guid CostSettlementId { get; set; }

        public string SettlementName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public Guid? SupplierId { get; set; }

        public string? ContractNumber { get; set; }

        public string? DiscountCode { get; set; }

        public Guid CostAgreementId { get; set; }

        public string? AgreementCode { get; set; }

        public string? AgreementName { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public DateTime EffectiveDate { get; set; }

        public bool IncludingTax { get; set; }

        public DateTime? TerminationDate { get; set; }

        public decimal? FixedCostAmount { get; set; }

        public decimal? FixedCostMarginAmount { get; set; }

        public decimal? OrderTotalMarginAmount { get; set; }

        public double? OrderTotalMarginPercentage { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}