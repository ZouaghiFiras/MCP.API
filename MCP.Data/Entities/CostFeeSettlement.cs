namespace CED.Data.Entities
{
    public class CostFeeSettlement
    {
        public Guid CfsId { get; set; }

        public byte[] CfsTimeStamp { get; set; } = null!;

        public string CfsSettlementName { get; set; } = null!;

        public Guid? CfsLegalEntityId { get; set; }

        public Guid? CfsClientId { get; set; }

        public string? CfsInvoiceDeliveryMethodId { get; set; }

        public string? CfsInvoiceRuleTypeId { get; set; }

        public Guid? CfsExchangeRateProviderId { get; set; }

        public string? CfsExchangeRateTypeId { get; set; }

        public string? CfsEntrySystem { get; set; }

        public string? CfsExchangeRateDateRuleId { get; set; }

        public string? CfsTaxDateRuleId { get; set; }

        public DateTime CfsCreatedDate { get; set; }

        public string? CfsCreatedBy { get; set; }

        public DateTime CfsLastModifiedDate { get; set; }

        public string? CfsLastModifiedBy { get; set; }

        public virtual Client? CfsClient { get; set; }

        public virtual ExchangeRateProvider? CfsExchangeRateProvider { get; set; }

        public virtual ExchangeRateType? CfsExchangeRateType { get; set; }

        public virtual InvoiceDeliveryMethod? CfsInvoiceDeliveryMethod { get; set; }

        public virtual InvoiceRuleType? CfsInvoiceRuleType { get; set; }

        public virtual LegalEntity? CfsLegalEntity { get; set; }

        public virtual ICollection<CostFeeSettlementLine> CostFeeSettlementLines { get; } =
            new List<CostFeeSettlementLine>();
    }
}