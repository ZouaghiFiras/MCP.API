namespace CED.Data.Entities
{
    public class PurchaseBacklogSummariesView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public bool? IsCredit { get; set; }

        public string? PaymentReference { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string? EntrySystem { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? AssistancePlanNumber { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public string? WorkingOrderNumber { get; set; }

        public Guid? WorkingOrderId { get; set; }

        public Guid? ClientId { get; set; }

        public string? SupplierVatNumber { get; set; }

        public string? SupplierNumber { get; set; }

        public string SupplierName { get; set; } = null!;

        public string? SupplierPostalCode { get; set; }

        public string? SupplierCity { get; set; }

        public string? PurchaseBacklogStatusCode { get; set; }

        public string? PurchaseBacklogStatusName { get; set; }

        public DateTime? PurchaseBacklogStatusCreatedDate { get; set; }

        public Guid? DocumentArchiveId { get; set; }

        public string? SourceTypeId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}