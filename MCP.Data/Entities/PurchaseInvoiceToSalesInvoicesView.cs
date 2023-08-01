namespace CED.Data.Entities
{
    public class PurchaseInvoiceToSalesInvoicesView
    {
        public Guid PurchaseInvoiceId { get; set; }

        public string PurchaseInvoiceNumber { get; set; } = null!;

        public DateTime PurchaseInvoiceDate { get; set; }

        public bool PurchaseInvoiceIsCredit { get; set; }

        public Guid? SalesInvoiceId { get; set; }

        public DateTime? SalesInvoiceDate { get; set; }

        public decimal? SalesInvoiceNetAmount { get; set; }

        public decimal? SalesInvoiceGrossAmount { get; set; }

        public decimal? SalesInvoiceTaxAmount { get; set; }

        public string? SalesInvoiceNumber { get; set; }

        public string? SalesInvoiceDebtorNumber { get; set; }

        public string SalesInvoiceDebtorName { get; set; } = null!;

        public string? SalesInvoiceStatusCode { get; set; }

        public string? SalesInvoiceStatusName { get; set; }

        public DateTime? SalesInvoicePaymentDate { get; set; }

        public bool? SalesInvoiceIsCredit { get; set; }

        public decimal PurchaseInvoiceGrossAmount { get; set; }

        public decimal PurchaseInvoiceNetAmount { get; set; }

        public decimal PurchaseInvoiceTaxAmount { get; set; }

        public Guid? DebtorId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}