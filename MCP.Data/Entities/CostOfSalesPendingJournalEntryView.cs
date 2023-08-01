namespace CED.Data.Entities
{
    public class CostOfSalesPendingJournalEntryView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public string PurchaseInvoiceNumber { get; set; } = null!;

        public DateTime DocumentDate { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryBatch { get; set; }

        public decimal NetAmount { get; set; }

        public bool IsImported { get; set; }

        public bool IsCredit { get; set; }

        public string? DebitEntryNumber { get; set; }
    }
}