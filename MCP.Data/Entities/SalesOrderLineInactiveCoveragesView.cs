namespace CED.Data.Entities
{
    public class SalesOrderLineInactiveCoveragesView
    {
        public Guid Id { get; set; }

        public Guid SalesOrderId { get; set; }

        public Guid AssistancePlanCoverageId { get; set; }

        public Guid InvolvedCoverageId { get; set; }

        public Guid DossierId { get; set; }

        public Guid CoverageProductId { get; set; }

        public string CoverageProductCode { get; set; } = null!;

        public string CoverageProductName { get; set; } = null!;
    }
}