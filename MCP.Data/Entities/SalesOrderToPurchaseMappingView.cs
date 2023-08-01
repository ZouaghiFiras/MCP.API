namespace CED.Data.Entities
{
    public class SalesOrderToPurchaseMappingView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public bool IsRecipientLegalEntity { get; set; }

        public Guid SalesOrderId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}