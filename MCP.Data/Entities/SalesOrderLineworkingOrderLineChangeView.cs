namespace CED.Data.Entities
{
    public class SalesOrderLineworkingOrderLineChangeView
    {
        public Guid SalesOrderLineId { get; set; }

        public Guid SalesOrderId { get; set; }

        public string SalesOrderNumber { get; set; } = null!;

        public decimal SalesOrderGrossAmount { get; set; }

        public int SalesOrderLineNumber { get; set; }

        public decimal SalesOrderLineGrossAmount { get; set; }

        public bool IsFee { get; set; }

        public Guid SalesOrderClientId { get; set; }

        public bool? WorkingOrderLineCoverageInactive { get; set; }

        public string? SalesOrderCurrentStatusCode { get; set; }

        public double SalesOrderLineQuantity { get; set; }

        public double? SalesOrderCorrectionLineQuantity { get; set; }

        public decimal? SalesOrderLineUnitPrice { get; set; }

        public decimal? SalesOrderCorrectionLineUnitPrice { get; set; }

        public decimal SalesOrderLineNetAmount { get; set; }

        public decimal? SalesOrderCorrectionLineCostOfSalesAmount { get; set; }

        public Guid? WorkingOrderLineId { get; set; }

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public Guid? WorkingOrderLineCostId { get; set; }

        public bool? WorkingOrderLineCostInactive { get; set; }

        public Guid? WorkingOrderLineCoverageId { get; set; }

        public Guid? ServiceId { get; set; }

        public string? ServiceCode { get; set; }

        public string? ServiceName { get; set; }
    }
}