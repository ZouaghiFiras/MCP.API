namespace CED.Data.Entities
{
    public class PurchaseOrderStatusHistory
    {
        public Guid PoshId { get; set; }

        public byte[] PoshTimeStamp { get; set; } = null!;

        public Guid PoshPurchaseOrderId { get; set; }

        public Guid PoshPurchaseOrderStatusId { get; set; }

        public Guid? PoshEmployeeId { get; set; }

        public DateTime PoshStartDate { get; set; }

        public DateTime PoshCreatedDate { get; set; }

        public string? PoshCreatedBy { get; set; }

        public DateTime PoshLastModifiedDate { get; set; }

        public string? PoshLastModifiedBy { get; set; }

        public virtual Employee? PoshEmployee { get; set; }

        public virtual PurchaseOrder PoshPurchaseOrder { get; set; } = null!;

        public virtual PurchaseOrderStatus PoshPurchaseOrderStatus { get; set; } = null!;
    }
}