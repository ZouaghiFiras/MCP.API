namespace CED.Data.Entities
{
    public class CreditTransferPurchaseInvoicesView
    {
        public Guid Id { get; set; }

        public Guid CreditTransferId { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        public Guid BankAccountId { get; set; }

        public string BankAccountNumber { get; set; } = null!;

        public string CreditTransferNumber { get; set; } = null!;

        public DateTime? ExecutionDate { get; set; }

        public decimal? CreditAmount { get; set; }

        public bool IsCredit { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string? RemittanceInformation { get; set; }

        public Guid LegalEntityId { get; set; }

        public string? CreditTransferStatus { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public Guid? SupplierId { get; set; }

        public string? SupplierCode { get; set; }

        public string SupplierName { get; set; } = null!;

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public Guid CreditorId { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public string CreditorName { get; set; } = null!;

        public string? ToIban { get; set; }

        public string? ToAccountNumber { get; set; }

        public string? ToBic { get; set; }

        public string? ToAccountHolderName { get; set; }

        public Guid PaymentBatchId { get; set; }

        public int PaymentBatchLineSequenceNumber { get; set; }

        public string PaymentBatchNumber { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}