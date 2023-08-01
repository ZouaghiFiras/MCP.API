namespace CED.Data.Entities
{
    public class JournalEntryLinesView
    {
        public Guid Id { get; set; }

        public Guid JournalEntryId { get; set; }

        public string JournalId { get; set; } = null!;

        public string JournalDescription { get; set; } = null!;

        public string? ExactJournal { get; set; }

        public string JournalNumber { get; set; } = null!;

        public int SequenceNumber { get; set; }

        public string? Description { get; set; }

        public DateTime? Date { get; set; }

        public string GeneralLedgerId { get; set; } = null!;

        public string GeneralLedgerDescription { get; set; } = null!;

        public string? ExactLedger { get; set; }

        public string? DebtorNumber { get; set; }

        public string? CreditorNumber { get; set; }

        public string? InvoiceNumber { get; set; }

        public decimal? DebitValue { get; set; }

        public decimal? CreditValue { get; set; }

        public string? CurrencyCode { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostUnitCode { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public int? LinkId { get; set; }

        public DateTime? LinkDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}