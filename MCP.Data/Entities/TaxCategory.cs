namespace CED.Data.Entities
{
    public class TaxCategory
    {
        public string TctId { get; set; } = null!;

        public byte[] TctTimeStamp { get; set; } = null!;

        public string TctDescription { get; set; } = null!;

        public bool TctInactive { get; set; }

        public Guid? TctLocalizableEntryId { get; set; }

        public DateTime TctCreatedDate { get; set; }

        public string? TctCreatedBy { get; set; }

        public DateTime TctLastModifiedDate { get; set; }

        public string? TctLastModifiedBy { get; set; }

        public virtual ICollection<LegalEntityTaxCategory> LegalEntityTaxCategories { get; } =
            new List<LegalEntityTaxCategory>();

        public virtual ICollection<LocationTaxRate> LocationTaxRates { get; } = new List<LocationTaxRate>();

        public virtual ICollection<ServiceTaxRate> ServiceTaxRates { get; } = new List<ServiceTaxRate>();

        public virtual LocalizableEntry? TctLocalizableEntry { get; set; }
    }
}