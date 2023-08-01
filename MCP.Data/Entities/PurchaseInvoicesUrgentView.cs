namespace CED.Data.Entities
{
    public class PurchaseInvoicesUrgentView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? DueDate { get; set; }

        public string? EntrySystem { get; set; }

        public Guid LegalEntityId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public string? PurchaseInvoiceStatusCode { get; set; }

        public DateTime? PurchaseInvoiceStatusCreatedDate { get; set; }

        public Guid? SupplierId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}