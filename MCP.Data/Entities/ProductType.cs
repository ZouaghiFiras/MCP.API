namespace CED.Data.Entities
{
    public class ProductType
    {
        public Guid PrtId { get; set; }

        public byte[] PrtTimeStamp { get; set; } = null!;

        public string PrtCode { get; set; } = null!;

        public string? PrtShortName { get; set; }

        public string PrtLongName { get; set; } = null!;

        public bool PrtInactive { get; set; }

        public bool PrtIsDamageType { get; set; }

        public DateTime PrtCreatedDate { get; set; }

        public string? PrtCreatedBy { get; set; }

        public DateTime PrtLastModifiedDate { get; set; }

        public string? PrtLastModifiedBy { get; set; }

        public virtual ICollection<Product> Products { get; } = new List<Product>();
    }
}