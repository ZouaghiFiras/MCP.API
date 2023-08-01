namespace CED.Data.Entities
{
    public class LocationTaxRate
    {
        public Guid LtrId { get; set; }

        public byte[] LtrTimeStamp { get; set; } = null!;

        public string LtrCountryIso2Code { get; set; } = null!;

        public string? LtrCity { get; set; }

        public string LtrDescription { get; set; } = null!;

        public double LtrTaxRate { get; set; }

        public string? LtrTaxCategoryId { get; set; }

        public DateTime LtrEffectiveDate { get; set; }

        public DateTime? LtrTerminationDate { get; set; }

        public bool? LtrIsAllowed { get; set; }

        public DateTime LtrCreatedDate { get; set; }

        public string? LtrCreatedBy { get; set; }

        public DateTime LtrLastModifiedDate { get; set; }

        public string? LtrLastModifiedBy { get; set; }

        public string? LtrObjectClassificationsName { get; set; }

        public bool? LtrIsSubContractor { get; set; }

        public virtual Country LtrCountryIso2CodeNavigation { get; set; } = null!;

        public virtual TaxCategory? LtrTaxCategory { get; set; }
    }
}