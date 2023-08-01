namespace CED.Data.Entities
{
    public class PurchaseInvoiceToAssistancePlanMappingsView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid PurchaseInvoiceLineId { get; set; }

        public Guid AssistancePlanId { get; set; }

        public Guid AssistancePlanLineId { get; set; }

        public bool Inactive { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}