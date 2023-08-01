namespace CED.Data.Entities
{
    public class SalesOrderLineAttribute
    {
        public Guid SolaId { get; set; }

        public byte[] SolaTimeStamp { get; set; } = null!;

        public Guid SolaSalesOrderLineId { get; set; }

        public string SolaAttributeName { get; set; } = null!;

        public string SolaAttributeContent { get; set; } = null!;

        public DateTime SolaCreatedDate { get; set; }

        public string? SolaCreatedBy { get; set; }

        public DateTime SolaLastModifiedDate { get; set; }

        public string? SolaLastModifiedBy { get; set; }

        public virtual SalesOrderLine SolaSalesOrderLine { get; set; } = null!;
    }
}