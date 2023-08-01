namespace CED.Data.Entities
{
    public class LcmexpiredPurchaseOrdersView
    {
        public Guid OrderId { get; set; }

        public string OrderNumber { get; set; } = null!;
    }
}