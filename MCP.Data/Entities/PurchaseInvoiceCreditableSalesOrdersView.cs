namespace CED.Data.Entities
{
    public class PurchaseInvoiceCreditableSalesOrdersView
    {
        public Guid Id { get; set; }

        public Guid? SalesOrderId { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}