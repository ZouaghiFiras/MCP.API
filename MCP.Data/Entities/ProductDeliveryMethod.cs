namespace CED.Data.Entities
{
    public class ProductDeliveryMethod
    {
        public Guid PdmId { get; set; }

        public byte[] PdmTimeStamp { get; set; } = null!;

        public Guid PdmProductId { get; set; }

        public Guid PdmDeliveryMethodId { get; set; }

        public bool PdmInactive { get; set; }

        public DateTime PdmCreatedDate { get; set; }

        public string? PdmCreatedBy { get; set; }

        public DateTime PdmLastModifiedDate { get; set; }

        public string? PdmLastModifiedBy { get; set; }

        public virtual DeliveryMethod PdmDeliveryMethod { get; set; } = null!;

        public virtual Product PdmProduct { get; set; } = null!;
    }
}