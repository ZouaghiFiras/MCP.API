namespace CED.Data.Entities
{
    public class PurchaseBacklogsView
    {
        public Guid Id { get; set; }

        public string BacklogsNumber { get; set; } = null!;

        public string? AssistancePlanNumber { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public DateTime BacklogsDate { get; set; }

        public decimal? BlockedAmount { get; set; }

        public string? CultureCode { get; set; }

        public string? CurrencyCode { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? TaxExemptedAmount { get; set; }

        public decimal? TaxImportAmount { get; set; }

        public decimal? TaxReversedChargeAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public DateTime? DueDate { get; set; }

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

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

        public Guid? TenantId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public bool? IsIntercompany { get; set; }

        public bool? IsRecipientLegalEntity { get; set; }

        public string? RecipientName { get; set; }

        public string? PayeeName { get; set; }

        public bool? IsInvoice { get; set; }

        public bool? IsCredit { get; set; }

        public string? PaymentReference { get; set; }

        public string? JsonEntryForm { get; set; }

        public string? PurchaseBacklogStatusCode { get; set; }

        public string? PurchaseBacklogStatusName { get; set; }

        public DateTime? PurchaseBacklogStatusCreatedDate { get; set; }

        public string? SourceFrom { get; set; }

        public string? SourceTo { get; set; }

        public DateTime? SourceReceivedDate { get; set; }

        public string? SourceSubject { get; set; }

        public string? SourceTypeId { get; set; }

        public string? InUseBy { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public Guid? PurchaseInvoiceId { get; set; }

        public string? OurReference { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}