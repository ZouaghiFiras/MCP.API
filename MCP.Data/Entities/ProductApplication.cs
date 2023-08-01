namespace CED.Data.Entities
{
    public class ProductApplication
    {
        public Guid PraId { get; set; }

        public byte[] PraTimeStamp { get; set; } = null!;

        public Guid PraProductId { get; set; }

        public Guid PraApplicationId { get; set; }

        public bool PraInactive { get; set; }

        public DateTime PraCreatedDate { get; set; }

        public string? PraCreatedBy { get; set; }

        public DateTime PraLastModifiedDate { get; set; }

        public string? PraLastModifiedBy { get; set; }

        public virtual Application PraApplication { get; set; } = null!;

        public virtual Product PraProduct { get; set; } = null!;
    }
}