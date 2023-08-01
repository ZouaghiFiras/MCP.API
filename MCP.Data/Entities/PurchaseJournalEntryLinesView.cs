namespace CED.Data.Entities
{
    public class PurchaseJournalEntryLinesView
    {
        public Guid Id { get; set; }

        public Guid JournalEntryId { get; set; }

        public int LineNumber { get; set; }

        public Guid PurchaseInvoiceLineId { get; set; }

        public string? PurchaseInvoiceLineLedgerAccount { get; set; }

        public string? ExactJournal { get; set; }

        public string? LeadCurrencyCode { get; set; }

        public string? PurchaseInvoiceCurrencyCode { get; set; }

        public double Quantity { get; set; }

        public decimal PurchaseInvoiceLineGrossAmount { get; set; }

        public string? TaxCode { get; set; }

        public decimal PurchaseInvoiceLineTaxAmount { get; set; }

        public decimal PurchaseInvoiceLineNetAmount { get; set; }

        public bool IsCredit { get; set; }

        public string? JournalEntryCurrencyCode { get; set; }

        public decimal? JournalEntryCreditValue { get; set; }

        public decimal? JournalEntryDebitValue { get; set; }

        public string JournalEntryLedgerAccount { get; set; } = null!;

        public short? ExactType { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}