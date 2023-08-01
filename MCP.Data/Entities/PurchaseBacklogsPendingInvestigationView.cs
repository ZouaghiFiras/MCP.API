namespace CED.Data.Entities
{
    public class PurchaseBacklogsPendingInvestigationView
    {
        public Guid Id { get; set; }

        public string BacklogsNumber { get; set; } = null!;

        public string? AssistancePlanNumber { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public string? WorkingOrderNumbers { get; set; }

        public Guid? WorkingOrderId { get; set; }

        public DateTime BacklogsDate { get; set; }

        public int? Priority { get; set; }

        public string? CurrencyCode { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public DateTime? DueDate { get; set; }

        public Guid? LegalEntityId { get; set; }

        public Guid? SupplierId { get; set; }

        public string? SupplierCode { get; set; }

        public string SupplierName { get; set; } = null!;

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string? SupplierIban { get; set; }

        public string? SupplierAccountNumber { get; set; }

        public Guid? PaymentConditionId { get; set; }

        public Guid? PaymentMethodId { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public string? PayeeName { get; set; }

        public bool? IsCredit { get; set; }

        public string? PaymentReference { get; set; }

        public string? PurchaseBacklogStatusCode { get; set; }

        public string? PurchaseBacklogStatusName { get; set; }

        public DateTime? PurchaseBacklogStatusCreatedDate { get; set; }

        public string? SourceFrom { get; set; }

        public string? SourceTo { get; set; }

        public DateTime? SourceReceivedDate { get; set; }

        public string? SourceSubject { get; set; }

        public string? SourceTypeId { get; set; }

        public string? InUseBy { get; set; }

        public bool IsMedicalDossier { get; set; }

        public bool IsUrgent { get; set; }

        public string? EntrySystem { get; set; }

        public DateTime? InvestigationDueDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}