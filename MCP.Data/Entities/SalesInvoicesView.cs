namespace CED.Data.Entities
{
    public class SalesInvoicesView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public bool IsCredit { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public string? EntrySystem { get; set; }

        public string? OurReference { get; set; }

        public string? YourReference { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public Guid? ClientId { get; set; }

        public string? ClientCode { get; set; }

        public string? ClientGroupCode { get; set; }

        public string? ClientGroupName { get; set; }

        public string ClientName { get; set; } = null!;

        public Guid DebtorId { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public string DebtorName { get; set; } = null!;

        public string? DebtorEmail { get; set; }

        public string? LicensePlate { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? AssignmentNumber { get; set; }

        public string? AssistancePlanNumbers { get; set; }

        public string? WorkingOrderNumber { get; set; }

        public string? SalesInvoiceStatusCode { get; set; }

        public string SalesInvoiceStatusName { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public bool? IsFee { get; set; }
    }
}