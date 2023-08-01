namespace CED.Data.Entities
{
    public class CreditTransfersPendingJournalEntryView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public Guid BankAccountId { get; set; }

        public decimal CreditAmount { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public DateTime? ExecutionDate { get; set; }

        public bool UrgentTransfer { get; set; }

        public string? AccountNumber { get; set; }

        public string? AccountHolderName { get; set; }

        public string? AccountAddressLine1 { get; set; }

        public string? AccountAddressLine2 { get; set; }

        public string? BankName { get; set; }

        public string? Iban { get; set; }

        public string? Bic { get; set; }

        public string? RemittanceInformation { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }
    }
}