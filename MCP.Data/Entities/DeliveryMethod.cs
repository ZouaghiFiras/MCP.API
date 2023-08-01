namespace CED.Data.Entities
{
    public class DeliveryMethod
    {
        public Guid DvmId { get; set; }

        public byte[] DvmTimeStamp { get; set; } = null!;

        public string DvmCode { get; set; } = null!;

        public string? DvmShortName { get; set; }

        public string DvmLongName { get; set; } = null!;

        public bool DvmInactive { get; set; }

        public Guid? DvmLocalizableEntryId { get; set; }

        public DateTime DvmCreatedDate { get; set; }

        public string? DvmCreatedBy { get; set; }

        public DateTime DvmLastModifiedDate { get; set; }

        public string? DvmLastModifiedBy { get; set; }

        public virtual LocalizableEntry? DvmLocalizableEntry { get; set; }

        public virtual ICollection<ProductDeliveryMethod> ProductDeliveryMethods { get; } =
            new List<ProductDeliveryMethod>();
    }
}