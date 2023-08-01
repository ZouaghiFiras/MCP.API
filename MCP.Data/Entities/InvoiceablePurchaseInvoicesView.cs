namespace CED.Data.Entities
{
    public class InvoiceablePurchaseInvoicesView
    {
        public Guid Id { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public decimal NetAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal? InvoiceableNetAmount { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string? EntrySystem { get; set; }

        public DateTime? StatusDate { get; set; }

        public string? StatusCode { get; set; }

        public string? StatusName { get; set; }

        public string? StatusChangeReason { get; set; }

        public string? SupplierNumber { get; set; }

        public string SupplierName { get; set; } = null!;

        public bool? SalesOrderChargedExpensesCreated { get; set; }

        public bool? SalesOrderChargedExpensesApproved { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}