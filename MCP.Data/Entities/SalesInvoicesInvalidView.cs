namespace CED.Data.Entities
{
    public class SalesInvoicesInvalidView
    {
        public Guid Id { get; set; }

        public string? Number { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public Guid? AuthorizationId { get; set; }

        public string? EntrySystem { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string? AssignmentNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? DebtorId { get; set; }

        public string? DebtorNumber { get; set; }

        public string? DebtorName { get; set; }

        public bool? IsManualCorrection { get; set; }

        public bool? IsDossierAssignmentCorrection { get; set; }

        public bool? IsWorkingOrderLineCorrection { get; set; }

        public Guid? WorkingOrderLineId { get; set; }

        public string? SalesOrderNumber { get; set; }

        public bool? IsInsurancePolicyCorrection { get; set; }

        public Guid? InsurancePolicyId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}