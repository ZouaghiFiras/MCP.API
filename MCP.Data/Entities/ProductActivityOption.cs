namespace CED.Data.Entities
{
    public class ProductActivityOption
    {
        public Guid PaoId { get; set; }

        public byte[] PaoTimeStamp { get; set; } = null!;

        public Guid PaoProductId { get; set; }

        public Guid PaoActivityOptionId { get; set; }

        public bool PaoInactive { get; set; }

        public DateTime PaoCreatedDate { get; set; }

        public string? PaoCreatedBy { get; set; }

        public DateTime PaoLastModifiedDate { get; set; }

        public string? PaoLastModifiedBy { get; set; }

        public virtual ActivityOption PaoActivityOption { get; set; } = null!;

        public virtual Product PaoProduct { get; set; } = null!;
    }
}