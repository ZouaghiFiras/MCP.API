namespace CED.Data.Entities
{
    public class ProductClassification
    {
        public Guid PrdcId { get; set; }

        public byte[] PrdcTimeStamp { get; set; } = null!;

        public string? PrdcCode { get; set; }

        public string PrdcName { get; set; } = null!;

        public bool PrdcInactive { get; set; }

        public Guid? PrdcLocalizableEntryId { get; set; }

        public DateTime PrdcCreatedDate { get; set; }

        public string? PrdcCreatedBy { get; set; }

        public DateTime PrdcLastModifiedDate { get; set; }

        public string? PrdcLastModifiedBy { get; set; }

        public virtual LocalizableEntry? PrdcLocalizableEntry { get; set; }

        public virtual ICollection<Product> Products { get; } = new List<Product>();
    }
}