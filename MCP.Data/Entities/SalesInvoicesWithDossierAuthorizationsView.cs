namespace CED.Data.Entities
{
    public class SalesInvoicesWithDossierAuthorizationsView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public string? EntrySystem { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid DebtorId { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public string DebtorName { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}