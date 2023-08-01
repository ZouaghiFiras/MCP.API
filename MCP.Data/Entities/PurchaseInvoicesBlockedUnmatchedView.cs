namespace CED.Data.Entities
{
    public class PurchaseInvoicesBlockedUnmatchedView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public bool IsCredit { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public DateTime InvoiceDate { get; set; }

        public int? Priority { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? DueDate { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public Guid LegalEntityId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public DateTime? PurchaseInvoiceStatusCreatedDate { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public string? AssistancePlanNumber { get; set; }

        public string? AssistancePlanCreatedBy { get; set; }

        public DateTime? AssistancePlanCreatedDate { get; set; }

        public string? AssistancePlanLastModifiedBy { get; set; }

        public DateTime? AssistancePlanLastModifiedDate { get; set; }

        public Guid? WorkingOrderId { get; set; }

        public string? WorkingOrderNumber { get; set; }

        public string? WorkingOrderCreatedBy { get; set; }

        public DateTime? WorkingOrderCreatedDate { get; set; }

        public string? WorkingOrderLastModifiedBy { get; set; }

        public DateTime? WorkingOrderLastModifiedDate { get; set; }

        public Guid? SupplierId { get; set; }

        public string? SupplierIban { get; set; }

        public string? SupplierAccountNumber { get; set; }

        public string? SupplierCode { get; set; }

        public string SupplierName { get; set; } = null!;

        public DateTime? SourceReceivedDate { get; set; }

        public string? SourceFrom { get; set; }

        public bool IsMedicalDossier { get; set; }

        public bool IsUrgent { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? DossierCreatedBy { get; set; }

        public string? DossierLastModifiedBy { get; set; }
    }
}