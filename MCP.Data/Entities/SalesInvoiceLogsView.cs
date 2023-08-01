namespace CED.Data.Entities
{
    public class SalesInvoiceLogsView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string InvoiceNumber { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid DebtorId { get; set; }

        public string DebtorName { get; set; } = null!;

        public bool IsCredit { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? EmployeeName { get; set; }

        public Guid? DossierId { get; set; }

        public DateTime? ProcessedDate { get; set; }

        public string? ProcessedBy { get; set; }

        public DateTime? SentDate { get; set; }

        public string? InvoiceDeliveryMethod { get; set; }

        public string? SentTo { get; set; }

        public DateTime? ConfirmationDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}