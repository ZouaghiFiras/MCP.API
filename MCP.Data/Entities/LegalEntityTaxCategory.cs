namespace CED.Data.Entities
{
    public class LegalEntityTaxCategory
    {
        public Guid LtcId { get; set; }

        public byte[] LtcTimeStamp { get; set; } = null!;

        public Guid LtcLegalEntityId { get; set; }

        public string LtcTaxCategoryId { get; set; } = null!;

        public string LtcTaxCode { get; set; } = null!;

        public bool LtcIsEuropeanCountry { get; set; }

        public DateTime LtcEffectiveDate { get; set; }

        public DateTime? LtcTerminationDate { get; set; }

        public DateTime LtcCreatedDate { get; set; }

        public string? LtcCreatedBy { get; set; }

        public DateTime LtcLastModifiedDate { get; set; }

        public string? LtcLastModifiedBy { get; set; }

        public virtual LegalEntity LtcLegalEntity { get; set; } = null!;

        public virtual TaxCategory LtcTaxCategory { get; set; } = null!;
    }
}