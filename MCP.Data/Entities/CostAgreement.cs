namespace CED.Data.Entities
{
    public class CostAgreement
    {
        public Guid CgrId { get; set; }

        public byte[] CgrTimeStamp { get; set; } = null!;

        public Guid CgrCostAgreementTypeId { get; set; }

        public string CgrCurrencyCode { get; set; } = null!;

        public DateTime CgrEffectiveDate { get; set; }

        public DateTime? CgrTerminationDate { get; set; }

        public bool CgrIncludingTax { get; set; }

        public string? CgrAgreementCode { get; set; }

        public string? CgrAgreementName { get; set; }

        public DateTime CgrCreatedDate { get; set; }

        public string? CgrCreatedBy { get; set; }

        public DateTime CgrLastModifiedDate { get; set; }

        public string? CgrLastModifiedBy { get; set; }

        public virtual CostAgreementType CgrCostAgreementType { get; set; } = null!;

        public virtual ICollection<CostSettlementLine> CostSettlementLines { get; } = new List<CostSettlementLine>();

        public virtual FixedCostAgreement? FixedCostAgreement { get; set; }
    }
}