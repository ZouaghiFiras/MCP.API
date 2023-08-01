namespace CED.Data.Entities
{
    public class CreditTransferJournalEntryCreationsView
    {
        public Guid Id { get; set; }

        public Guid CreditTransferId { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public Guid PaymentBatchId { get; set; }

        public DateTime InvoiceDate { get; set; }

        public double? PaymentExchangeRate { get; set; }

        public Guid? PaymentExchangeRateId { get; set; }

        public decimal GrossAmount { get; set; }

        public bool IsCredit { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string? LeadCurrencyCode { get; set; }

        public string JournalCurrencyCode { get; set; } = null!;

        public string? EntrySystem { get; set; }

        public string GeneralLedgerId { get; set; } = null!;

        public string CreditorNumber { get; set; } = null!;

        public Guid CreditorId { get; set; }

        public Guid LegalEntityId { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostUnitCode { get; set; }
    }
}