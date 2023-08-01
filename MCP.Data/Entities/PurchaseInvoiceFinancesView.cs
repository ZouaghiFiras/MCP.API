namespace CED.Data.Entities
{
    public class PurchaseInvoiceFinancesView
    {
        public Guid Id { get; set; }

        public Guid? DossierId { get; set; }

        public decimal? RemainingNetAmount { get; set; }

        public decimal NetAmount { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal SalesOrderNetAmount { get; set; }

        public decimal CostOfSalesAmount { get; set; }

        public string? PurchaseInvoiceStatusCode { get; set; }

        public string? PurchaseInvoiceStatusName { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}