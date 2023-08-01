namespace CED.Data.Entities
{
    public class CostFeeSettlementLine
    {
        public Guid CflId { get; set; }

        public byte[] CflTimeStamp { get; set; } = null!;

        public Guid CflCostFeeSettlementId { get; set; }

        public Guid CflServiceId { get; set; }

        public DateTime CflEffectiveDate { get; set; }

        public DateTime? CflTerminationDate { get; set; }

        public string? CflExchangeRateDateRuleId { get; set; }

        public string? CflTaxDateRuleId { get; set; }

        public DateTime CflCreatedDate { get; set; }

        public string? CflCreatedBy { get; set; }

        public DateTime CflLastModifiedDate { get; set; }

        public string? CflLastModifiedBy { get; set; }

        public virtual CostFeeSettlement CflCostFeeSettlement { get; set; } = null!;

        public virtual Service CflService { get; set; } = null!;
    }
}