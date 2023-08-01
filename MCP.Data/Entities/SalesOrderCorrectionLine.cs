namespace CED.Data.Entities
{
    public class SalesOrderCorrectionLine
    {
        public Guid SolcId { get; set; }

        public byte[] SolcTimeStamp { get; set; } = null!;

        public Guid SolcSalesOrderCorrectionId { get; set; }

        public Guid SolcSalesOrderLineId { get; set; }

        public double? SolcQuantity { get; set; }

        public decimal? SolcUnitPrice { get; set; }

        public Guid? SolcClientId { get; set; }

        public Guid? SolcInvolvedCoverageId { get; set; }

        public decimal? SolcCostOfSalesAmount { get; set; }

        public DateTime SolcCreatedDate { get; set; }

        public string? SolcCreatedBy { get; set; }

        public DateTime SolcLastModifiedDate { get; set; }

        public string? SolcLastModifiedBy { get; set; }

        public virtual Client? SolcClient { get; set; }

        public virtual InvolvedCoverage? SolcInvolvedCoverage { get; set; }

        public virtual SalesOrderCorrection SolcSalesOrderCorrection { get; set; } = null!;

        public virtual SalesOrderLine SolcSalesOrderLine { get; set; } = null!;
    }
}