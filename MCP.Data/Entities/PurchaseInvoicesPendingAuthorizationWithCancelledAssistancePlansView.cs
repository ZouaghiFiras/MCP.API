namespace CED.Data.Entities
{
    public class PurchaseInvoicesPendingAuthorizationWithCancelledAssistancePlansView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public bool IsCredit { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? DueDate { get; set; }

        public bool IsImported { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? DossierPartyId { get; set; }

        public bool PayorIsDossierParty { get; set; }

        public bool IsIntercompany { get; set; }

        public string? Journal { get; set; }

        public Guid? CostCenterId { get; set; }

        public Guid? CostUnitId { get; set; }

        public bool IsRecipientLegalEntity { get; set; }

        public string? RecipientName { get; set; }

        public string? PayeeName { get; set; }

        public bool IsInvoice { get; set; }

        public string? CreditReason { get; set; }

        public string? PurchaseInvoiceStatusCode { get; set; }

        public string? PurchaseInvoiceStatusName { get; set; }

        public DateTime? PurchaseInvoiceStatusCreatedDate { get; set; }

        public Guid? PurchaseInvoiceAssistancePlanId { get; set; }

        public Guid? PurchaseInvoiceLineAssistancePlanId { get; set; }

        public string? PurchaseInvoiceAssistancePlanStatusCode { get; set; }

        public string? PurchaseInvoiceAssistancePlanStatusName { get; set; }

        public string? PurchaseInvoiceLineAssistancePlanStatusCode { get; set; }

        public string? PurchaseInvoiceLineAssistancePlanStatusName { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}