namespace CED.Data.Entities
{
    public class PurchaseBacklogsCancelledView
    {
        public Guid Id { get; set; }

        public string? SupplierCode { get; set; }

        public string SupplierName { get; set; } = null!;

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? DueDate { get; set; }

        public string? EntrySystem { get; set; }

        public bool? DossierValidationResult { get; set; }

        public string? DossierValidationReason { get; set; }

        public bool? WorkActivityValidationResult { get; set; }

        public string? WorkActivityValidationReason { get; set; }

        public bool? ThirdPartyValidationResult { get; set; }

        public string? ThirdPartyValidationReason { get; set; }

        public bool? SupplierValidationResult { get; set; }

        public string? SupplierValidationReason { get; set; }

        public bool? SupplierInvoiceNumberValidationResult { get; set; }

        public string? SupplierInvoiceNumberValidationReason { get; set; }

        public bool? PeriodValidationResult { get; set; }

        public string? PeriodValidationReason { get; set; }

        public bool? StorageCostValidationResult { get; set; }

        public string? StorageCostValidationReason { get; set; }

        public bool? VatValidationResult { get; set; }

        public string? VatValidationReason { get; set; }

        public bool? VatNumberValidationResult { get; set; }

        public string? VatNumberValidationReason { get; set; }

        public bool? AssistancePlanCancelledValidationResult { get; set; }

        public string? AssistancePlanCancelledValidationReason { get; set; }

        public DateTime? CancelledDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}