namespace CED.Data.Entities
{
    public class PurchaseInvoiceLinesFailedSalesOrder
    {
        public Guid Id { get; set; }

        public decimal NetAmount { get; set; }

        public decimal GrossAmount { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string? EntrySystem { get; set; }

        public decimal SalesOrderAmount { get; set; }

        public decimal CostOfSalesAmount { get; set; }

        public decimal? PendingAmount { get; set; }

        public string FailedReason { get; set; } = null!;
    }
}