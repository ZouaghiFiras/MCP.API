namespace CED.Data.Entities
{
    public class PurchaseOrdersWithAcceptedPurchaseInvoicesView
    {
        public Guid Id { get; set; }

        public string OrderNumber { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        public bool IsCredit { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? TaxExemptedAmount { get; set; }

        public decimal? TaxReversedChargeAmount { get; set; }

        public decimal? TaxImportAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public string? CultureCode { get; set; }

        public DateTime? ExpectedDeliveryDate { get; set; }

        public bool IsImported { get; set; }

        public bool IsPrinted { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid DepartmentId { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? DossierPartyId { get; set; }

        public Guid? DocumentArchiveId { get; set; }

        public bool IsIntercompany { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? InvoiceToPayorId { get; set; }

        public string? DossierNumber { get; set; }

        public string? PurchaseOrderStatusCode { get; set; }

        public string PurchaseOrderStatusName { get; set; } = null!;

        public Guid? AssistancePlanId { get; set; }

        public string? AssistancePlanNumber { get; set; }

        public bool? InvoiceRecipientIsLegalEntity { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string? PurchaseInvoiceStatusCode { get; set; }

        public string PurchaseInvoiceStatusName { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}