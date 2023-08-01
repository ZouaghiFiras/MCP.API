namespace CED.Data.Entities
{
    public class SalesOrderToAssistancePlanCoverageMapping
    {
        public Guid SotcId { get; set; }

        public byte[] SotcTimeStamp { get; set; } = null!;

        public Guid SotcSalesOrderLineId { get; set; }

        public Guid SotcAssistancePlanCoverageId { get; set; }

        public DateTime SotcCreatedDate { get; set; }

        public string? SotcCreatedBy { get; set; }

        public DateTime SotcLastModifiedDate { get; set; }

        public string? SotcLastModifiedBy { get; set; }

        public virtual AssistancePlanCoverage SotcAssistancePlanCoverage { get; set; } = null!;

        public virtual SalesOrderLine SotcSalesOrderLine { get; set; } = null!;
    }
}