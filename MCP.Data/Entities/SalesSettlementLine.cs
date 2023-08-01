namespace CED.Data.Entities
{
    public class SalesSettlementLine
    {
        public Guid StlId { get; set; }

        public byte[] StlTimeStamp { get; set; } = null!;

        public Guid StlSalesSettlementId { get; set; }

        public int StlLineNumber { get; set; }

        public Guid StlServiceId { get; set; }

        public Guid StlProductId { get; set; }

        public Guid StlSalesAgreementId { get; set; }

        public DateTime StlCreatedDate { get; set; }

        public string? StlCreatedBy { get; set; }

        public DateTime StlLastModifiedDate { get; set; }

        public string? StlLastModifiedBy { get; set; }

        public DateTime? StlEffectiveDate { get; set; }

        public DateTime? StlTerminationDate { get; set; }

        public virtual Product StlProduct { get; set; } = null!;

        public virtual SalesAgreement StlSalesAgreement { get; set; } = null!;

        public virtual SalesSettlement StlSalesSettlement { get; set; } = null!;

        public virtual Service StlService { get; set; } = null!;
    }
}