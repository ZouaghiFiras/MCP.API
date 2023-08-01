namespace CED.Data.Entities
{
    public class ProductGroup
    {
        public Guid PrgId { get; set; }

        public byte[] PrgTimeStamp { get; set; } = null!;

        public string PrgCode { get; set; } = null!;

        public string? PrgShortName { get; set; }

        public string PrgLongName { get; set; } = null!;

        public bool PrgInactive { get; set; }

        public Guid? PrgLocalizableEntryId { get; set; }

        public DateTime PrgCreatedDate { get; set; }

        public string? PrgCreatedBy { get; set; }

        public DateTime PrgLastModifiedDate { get; set; }

        public string? PrgLastModifiedBy { get; set; }

        public virtual LocalizableEntry? PrgLocalizableEntry { get; set; }

        public virtual ICollection<Product> Products { get; } = new List<Product>();
    }
}