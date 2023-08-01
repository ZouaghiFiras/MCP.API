namespace CED.Data.Entities
{
    public class ProductDamageReasonsHierarchyView
    {
        public string ProductTypeCode { get; set; } = null!;

        public string? ProductTypeName { get; set; }

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public string? MainReasonCode { get; set; }

        public string? MainReasonName { get; set; }

        public string? SubReasonCode { get; set; }

        public string? SubReasonName { get; set; }

        public string? TertiaryReasonCode { get; set; }

        public string? TertiaryReasonName { get; set; }
    }
}