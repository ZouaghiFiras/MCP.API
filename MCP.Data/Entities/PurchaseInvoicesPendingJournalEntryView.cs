namespace CED.Data.Entities
{
    public class PurchaseInvoicesPendingJournalEntryView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public bool IsCredit { get; set; }

        public string? Description { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? DueDate { get; set; }

        public bool IsImported { get; set; }

        public string? EntrySystem { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public string CreditorName { get; set; } = null!;

        public bool CreditorIsCompany { get; set; }
    }
}