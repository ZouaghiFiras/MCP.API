namespace CED.Data.Entities
{
    public class PurchaseInvoiceLogsView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string InvoiceNumber { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid CreditorId { get; set; }

        public bool IsCredit { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? EmployeeName { get; set; }

        public Guid? DossierId { get; set; }

        public DateTime? AuthorizationDate { get; set; }

        public string? AuthorizedBy { get; set; }

        public DateTime? TransferDate { get; set; }

        public string? TransferedBy { get; set; }

        public DateTime? PaymentDate { get; set; }

        public string? CreditTransferIban { get; set; }

        public string? CreditTransferAccountNumber { get; set; }

        public Guid? CreditPurchaseInvoiceId { get; set; }

        public string? CreditInvoiceNumber { get; set; }

        public string? CreditEntryNumber { get; set; }

        public DateTime? CreditInvoiceRegistrationDate { get; set; }

        public string? CreditInvoiceCreatedBy { get; set; }

        public Guid? DebitPurchaseInvoiceId { get; set; }

        public string? DebitInvoiceNumber { get; set; }

        public string? DebitEntryNumber { get; set; }

        public DateTime? DebitInvoiceRegistrationDate { get; set; }

        public string? DebitInvoiceCreatedBy { get; set; }

        public Guid? BatchId { get; set; }

        public string? BatchNumber { get; set; }

        public DateTime? SepaDate { get; set; }

        public string? SepaCreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}