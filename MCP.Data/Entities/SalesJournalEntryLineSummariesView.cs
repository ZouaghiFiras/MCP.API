namespace CED.Data.Entities
{
    public class SalesJournalEntryLineSummariesView
    {
        public Guid SalesInvoiceLineId { get; set; }

        public bool IsCreditSalesInvoiceLine { get; set; }

        public Guid SalesInvoiceId { get; set; }

        public string SalesInvoiceNumber { get; set; } = null!;

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

        public Guid DebtorId { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public string DebtorName { get; set; } = null!;
    }
}