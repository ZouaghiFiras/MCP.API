namespace CED.Data.Entities
{
    public class PurchaseInvoiceToWorkingOrderMappingsView
    {
        public Guid? Id { get; set; }

        public Guid? PurchaseInvoiceId { get; set; }

        public Guid? PurchaseInvoiceLineId { get; set; }

        public Guid WorkingOrderLineId { get; set; }

        public Guid WorkingOrderLineCostId { get; set; }

        public bool? WorkingOrderLineCostInactive { get; set; }

        public bool? PurchaseInvoiceWorkingOrderInactive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}