namespace CED.Data.Entities
{
    public class PurchaseBacklogsUnprocessedReportsView
    {
        public Guid Id { get; set; }

        public bool? IsCredit { get; set; }

        public string? PaymentReference { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string? DossierNumber { get; set; }

        public string? EntrySystem { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public Guid? DossierId { get; set; }

        public string? SupplierNumber { get; set; }

        public string SupplierName { get; set; } = null!;

        public string? PurchaseBacklogStatusCode { get; set; }

        public string? PurchaseBacklogStatusName { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}