namespace CED.Data.Entities
{
    public class ModelProduct
    {
        public Guid MdpId { get; set; }

        public byte[] MdpTimeStamp { get; set; } = null!;

        public Guid MdpModelId { get; set; }

        public Guid MdpProductId { get; set; }

        public bool MdpInactive { get; set; }

        public string? MdpCreatedBy { get; set; }

        public DateTime MdpCreatedDate { get; set; }

        public string? MdpLastModifiedBy { get; set; }

        public DateTime MdpLastModifiedDate { get; set; }

        public virtual Model MdpModel { get; set; } = null!;

        public virtual Product MdpProduct { get; set; } = null!;
    }
}