namespace CED.Data.Entities
{
    public class ProductProperty
    {
        public Guid PrpId { get; set; }

        public byte[] PrpTimeStamp { get; set; } = null!;

        public Guid PrpProductId { get; set; }

        public string PrpEnumPropertyId { get; set; } = null!;

        public DateTime PrpCreatedDate { get; set; }

        public string? PrpCreatedBy { get; set; }

        public DateTime PrpLastModifiedDate { get; set; }

        public string? PrpLastModifiedBy { get; set; }
    }
}