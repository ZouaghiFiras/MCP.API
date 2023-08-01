namespace CED.Data.Entities
{
    public class PurchaseInvoiceAssistancePlan
    {
        public Guid PaplId { get; set; }

        public byte[] PaplTimeStamp { get; set; } = null!;

        public Guid PaplPurchaseInvoiceLineId { get; set; }

        public Guid PaplAssistancePlanLineId { get; set; }

        public bool PaplInactive { get; set; }

        public DateTime PaplCreatedDate { get; set; }

        public string? PaplCreatedBy { get; set; }

        public DateTime PaplLastModifiedDate { get; set; }

        public string? PaplLastModifiedBy { get; set; }

        public virtual AssistancePlanLine PaplAssistancePlanLine { get; set; } = null!;

        public virtual PurchaseInvoiceLine PaplPurchaseInvoiceLine { get; set; } = null!;
    }
}