namespace CED.Data.Entities
{
    public class SupplierBrand
    {
        public Guid SsbId { get; set; }

        public byte[] SsbTimeStamp { get; set; } = null!;

        public Guid SsbSupplierId { get; set; }

        public Guid SsbBrandId { get; set; }

        public DateTime SsbEffectiveDate { get; set; }

        public DateTime? SsbEndDate { get; set; }

        public DateTime SsbCreatedDate { get; set; }

        public string? SsbCreatedBy { get; set; }

        public DateTime SsbLastModifiedDate { get; set; }

        public string? SsbLastModifiedBy { get; set; }

        public virtual Brand SsbBrand { get; set; } = null!;

        public virtual Supplier SsbSupplier { get; set; } = null!;
    }
}