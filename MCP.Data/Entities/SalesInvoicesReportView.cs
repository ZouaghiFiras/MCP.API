namespace CED.Data.Entities
{
    public class SalesInvoicesReportView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public bool IsCredit { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public string? EntrySystem { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid DebtorId { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public string DebtorName { get; set; } = null!;

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public DateTime? IntakeDate { get; set; }

        public string? IncidentNumber { get; set; }

        public DateTime? IncidentDate { get; set; }

        public bool IsCollectable { get; set; }

        public DateTime? CollectableDate { get; set; }

        public Guid? DepartmentId { get; set; }

        public string? DepartmentName { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}