namespace CED.Data.Entities
{
    public class PurchaseJournalEntriesExactView
    {
        public Guid Id { get; set; }

        public string JournalId { get; set; } = null!;

        public string JournalTypeId { get; set; } = null!;

        public Guid LegalEntityId { get; set; }

        public string? ExactJournal { get; set; }

        public DateTime JournalEntryDate { get; set; }

        public string JournalEntryNumber { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public string? AccountNumber { get; set; }

        public Guid CreditorId { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public string? Description { get; set; }

        public decimal GrossAmount { get; set; }

        public DateTime? DueDate { get; set; }

        public string? CurrencyCode { get; set; }

        public string? BankCurrencyCode { get; set; }

        public double? ExchangeRate { get; set; }

        public string? PaymentConditionCode { get; set; }

        public decimal BlockedAmount { get; set; }

        public string? PaymentMethodCode { get; set; }

        public string? BookingNumber { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string? PaymentReference { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostUnitCode { get; set; }

        public DateTime? ExactExportDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}