namespace CED.Data.Entities
{
    public class SalesInvoiceToPurchaseFeeOnlyMappingView
    {
        public Guid Id { get; set; }

        public Guid SalesInvoiceId { get; set; }

        public Guid SalesInvoiceLineId { get; set; }

        public decimal SalesInvoiceLineNetAmount { get; set; }

        public decimal SalesInvoiceLineGrossAmount { get; set; }

        public decimal SalesInvoiceLineTaxAmount { get; set; }

        public bool SalesInvoiceLineIsCredit { get; set; }

        public Guid? SalesOrderLineId { get; set; }

        public Guid SalesOrderId { get; set; }

        public string SalesOrderNumber { get; set; } = null!;

        public bool IsFee { get; set; }

        public Guid ProductId { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public string? WorkActivityCode { get; set; }

        public string? WorkActivityLongName { get; set; }

        public string? ActivityOption { get; set; }
    }
}