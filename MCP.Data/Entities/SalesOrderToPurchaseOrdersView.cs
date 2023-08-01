namespace CED.Data.Entities
{
    public class SalesOrderToPurchaseOrdersView
    {
        public Guid Id { get; set; }

        public string OrderNumber { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        public string SupplierName { get; set; } = null!;

        public string? AssistancePlanNumber { get; set; }

        public bool IsCredit { get; set; }

        public bool? OnNameOfCed { get; set; }

        public Guid SalesOrderId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}