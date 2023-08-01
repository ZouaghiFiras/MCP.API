namespace CED.Data.Entities
{
    public class ProductWorkActivity
    {
        public Guid PwaId { get; set; }

        public byte[] PwaTimeStamp { get; set; } = null!;

        public Guid PwaProductId { get; set; }

        public Guid PwaWorkActivityId { get; set; }

        public bool PwaInactive { get; set; }

        public bool PwaIsIncluded { get; set; }

        public bool PwaIsMain { get; set; }

        public DateTime PwaCreatedDate { get; set; }

        public string? PwaCreatedBy { get; set; }

        public DateTime PwaLastModifiedDate { get; set; }

        public string? PwaLastModifiedBy { get; set; }

        public virtual Product PwaProduct { get; set; } = null!;

        public virtual WorkActivity PwaWorkActivity { get; set; } = null!;
    }
}