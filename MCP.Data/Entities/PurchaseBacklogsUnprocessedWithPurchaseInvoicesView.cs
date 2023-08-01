namespace CED.Data.Entities
{
    public class PurchaseBacklogsUnprocessedWithPurchaseInvoicesView
    {
        public Guid Id { get; set; }

        public Guid? PurchaseBacklogId { get; set; }

        public bool? IsCredit { get; set; }

        public string? OurReference { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public string? EntrySystem { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public string? SupplierNumber { get; set; }

        public string SupplierName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public string? StatusCode { get; set; }

        public string? StatusName { get; set; }

        public DateTime? StatusCreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}