namespace CED.Data.Entities
{
    public class PurchasePaymentsPendingJournalEntryView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid BankStatementLineId { get; set; }

        public decimal PaymentValue { get; set; }

        public string Number { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string? EntrySystem { get; set; }

        public int StatementNumber { get; set; }

        public int StatementYear { get; set; }

        public int SequenceNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal TransactionValue { get; set; }
    }
}