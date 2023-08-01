namespace CED.Data.Entities
{
    public class SalesInvoiceFailedPdfview
    {
        public Guid Id { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public string? EntrySystem { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TaxExemptedAmount { get; set; }

        public decimal TaxReversedChargeAmount { get; set; }

        public decimal TaxImportAmount { get; set; }

        public decimal NetAmount { get; set; }

        public decimal? OpenAmount { get; set; }

        public DateTime? DueDate { get; set; }

        public string? CurrencyCode { get; set; }

        public double? ExchangeRate { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid DebtorId { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public string DebtorName { get; set; } = null!;

        public string? DebtorEmailAddress { get; set; }

        public bool IsCredit { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string? AssignmentNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? SalesCollectionId { get; set; }

        public string? CollectionNumber { get; set; }

        public string DocumentType { get; set; } = null!;

        public string? PdfcreationStatus { get; set; }

        public string FormatDocument { get; set; } = null!;

        public string? SalesInvoiceStatusName { get; set; }

        public string? SalesInvoiceStatusChangeReason { get; set; }

        public string? ClientName { get; set; }

        public string? ClientCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }
    }
}