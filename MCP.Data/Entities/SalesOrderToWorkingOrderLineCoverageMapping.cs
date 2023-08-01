namespace CED.Data.Entities
{
    public class SalesOrderToWorkingOrderLineCoverageMapping
    {
        public Guid SotwcId { get; set; }

        public byte[] SotwcTimeStamp { get; set; } = null!;

        public Guid SotwcSalesOrderLineId { get; set; }

        public Guid SotwcWorkingOrderLineCoverageId { get; set; }

        public DateTime SotwcCreatedDate { get; set; }

        public string? SotwcCreatedBy { get; set; }

        public DateTime SotwcLastModifiedDate { get; set; }

        public string? SotwcLastModifiedBy { get; set; }

        public virtual SalesOrderLine SotwcSalesOrderLine { get; set; } = null!;

        public virtual WorkingOrderLineCoverage SotwcWorkingOrderLineCoverage { get; set; } = null!;
    }
}