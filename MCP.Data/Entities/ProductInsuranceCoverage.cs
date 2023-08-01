namespace CED.Data.Entities
{
    public class ProductInsuranceCoverage
    {
        public Guid PicId { get; set; }

        public byte[] PicTimeStamp { get; set; } = null!;

        public Guid PicProductId { get; set; }

        public Guid PicInsuranceCoverageId { get; set; }

        public bool PicInactive { get; set; }

        public DateTime PicCreatedDate { get; set; }

        public string? PicCreatedBy { get; set; }

        public DateTime PicLastModifiedDate { get; set; }

        public string? PicLastModifiedBy { get; set; }

        public virtual InsuranceCoverage PicInsuranceCoverage { get; set; } = null!;

        public virtual Product PicProduct { get; set; } = null!;
    }
}