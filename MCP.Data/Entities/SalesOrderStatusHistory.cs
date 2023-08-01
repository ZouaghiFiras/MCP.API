namespace CED.Data.Entities
{
    public class SalesOrderStatusHistory
    {
        public Guid SoshId { get; set; }

        public byte[] SoshTimeStamp { get; set; } = null!;

        public Guid SoshSalesOrderId { get; set; }

        public Guid SoshSalesOrderStatusId { get; set; }

        public DateTime SoshStartDate { get; set; }

        public DateTime SoshCreatedDate { get; set; }

        public string? SoshCreatedBy { get; set; }

        public DateTime SoshLastModifiedDate { get; set; }

        public string? SoshLastModifiedBy { get; set; }

        public string? SoshStatusChangeReason { get; set; }

        public virtual SalesOrder SoshSalesOrder { get; set; } = null!;

        public virtual SalesOrderStatus SoshSalesOrderStatus { get; set; } = null!;
    }
}