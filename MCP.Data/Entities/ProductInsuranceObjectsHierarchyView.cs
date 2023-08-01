namespace CED.Data.Entities
{
    public class ProductInsuranceObjectsHierarchyView
    {
        public string ProductTypeCode { get; set; } = null!;

        public string? ProductTypeName { get; set; }

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public string? MainObjectCode { get; set; }

        public string? MainObjectName { get; set; }

        public string? SecondObjectCode { get; set; }

        public string? SecondObjectName { get; set; }

        public string? ThirdObjectCode { get; set; }

        public string? ThirdObjectName { get; set; }
    }
}