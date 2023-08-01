namespace CED.Data.Entities
{
    public class Brand
    {
        public Guid BrnId { get; set; }

        public byte[] BrnTimeStamp { get; set; } = null!;

        public string BrnCode { get; set; } = null!;

        public string? BrnShortName { get; set; }

        public string BrnLongName { get; set; } = null!;

        public bool BrnInactive { get; set; }

        public Guid? BrnLocalizableEntryId { get; set; }

        public string? BrnCreatedBy { get; set; }

        public DateTime BrnCreatedDate { get; set; }

        public string? BrnLastModifiedBy { get; set; }

        public DateTime BrnLastModifiedDate { get; set; }

        public virtual LocalizableEntry? BrnLocalizableEntry { get; set; }

        public virtual ICollection<Model> Models { get; } = new List<Model>();

        public virtual ICollection<SupplierBrand> SupplierBrands { get; } = new List<SupplierBrand>();
    }
}