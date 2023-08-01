namespace CED.Data.Entities
{
    public class GeneralJournalEntryLinesExactView
    {
        public Guid Id { get; set; }

        public Guid JournalEntryId { get; set; }

        public string GeneralLedgerId { get; set; } = null!;

        public int LineNumber { get; set; }

        public string? Description { get; set; }

        public string? ExactGeneralLedger { get; set; }

        public string? ExactJournal { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostUnitCode { get; set; }

        public decimal? Amount { get; set; }

        public Guid? CreditorId { get; set; }

        public string? CreditorNumber { get; set; }

        public Guid? DebtorId { get; set; }

        public string? DebtorNumber { get; set; }

        public string? CurrencyCode { get; set; }

        public string? TaxCode { get; set; }

        public decimal? TaxValue { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public string? InvoiceNumber { get; set; }

        public string? DossierNumber { get; set; }

        public decimal? ExchangeRate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}