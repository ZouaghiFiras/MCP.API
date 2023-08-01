namespace CED.Data.Entities
{
    public class CostSettlementLine
    {
        public Guid CtlId { get; set; }

        public byte[] CtlTimeStamp { get; set; } = null!;

        public Guid CtlCostSettlementId { get; set; }

        public int CtlLineNumber { get; set; }

        public Guid CtlServiceId { get; set; }

        public Guid CtlCostAgreementId { get; set; }

        public DateTime CtlCreatedDate { get; set; }

        public string? CtlCreatedBy { get; set; }

        public DateTime CtlLastModifiedDate { get; set; }

        public string? CtlLastModifiedBy { get; set; }

        public virtual CostAgreement CtlCostAgreement { get; set; } = null!;

        public virtual CostSettlement CtlCostSettlement { get; set; } = null!;

        public virtual Service CtlService { get; set; } = null!;
    }
}