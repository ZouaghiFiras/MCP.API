namespace CED.Data.Entities
{
    public class PurchaseInvoiceToPurchaseOrderMappingsView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid PurchaseInvoiceLineId { get; set; }

        public bool PurchaseInvoiceLineIsCredit { get; set; }

        public decimal PurchaseInvoiceLineGrossAmount { get; set; }

        public Guid PurchaseOrderId { get; set; }

        public Guid PurchaseOrderLineId { get; set; }

        public decimal? PurchaseOrderLineGrossAmount { get; set; }

        public bool Inactive { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}