namespace CED.Data.Entities
{
    public class ProductHierarchy
    {
        public Guid PrhId { get; set; }

        public byte[] PrhTimeStamp { get; set; } = null!;

        public Guid PrhParentProductId { get; set; }

        public DateTime PrhStartDate { get; set; }

        public DateTime PrhEndDate { get; set; }

        public DateTime PrhCreatedDate { get; set; }

        public string? PrhCreatedBy { get; set; }

        public DateTime PrhLastModifiedDate { get; set; }

        public string? PrhLastModifiedBy { get; set; }

        public Guid? PrhChildProductId { get; set; }

        public virtual Product? PrhChildProduct { get; set; }

        public virtual Product PrhParentProduct { get; set; } = null!;
    }
}