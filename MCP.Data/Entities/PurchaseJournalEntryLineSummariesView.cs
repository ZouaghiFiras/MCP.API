namespace CED.Data.Entities
{
    public class PurchaseJournalEntryLineSummariesView
    {
        public Guid PurchaseInvoiceLineId { get; set; }

        public bool IsCreditPurchaseInvoiceLine { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string PurchaseInvoiceNumber { get; set; } = null!;

        public Guid LegalEntityId { get; set; }

        public Guid JournalEntryId { get; set; }

        public DateTime JournalEntryDate { get; set; }

        public string JournalEntryNumber { get; set; } = null!;

        public string JournalId { get; set; } = null!;

        public string? ExactJournal { get; set; }

        public string JournalType { get; set; } = null!;

        public Guid JournalEntryLineId { get; set; }

        public decimal? CreditValue { get; set; }

        public decimal? DebitValue { get; set; }

        public string? CurrencyCode { get; set; }

        public string? TaxCode { get; set; }

        public decimal? TaxValue { get; set; }

        public string GeneralLedgerId { get; set; } = null!;

        public string? ExactGeneralLedger { get; set; }

        public string GeneralLedgerDescription { get; set; } = null!;

        public Guid CreditorId { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public string CreditorName { get; set; } = null!;
    }
}