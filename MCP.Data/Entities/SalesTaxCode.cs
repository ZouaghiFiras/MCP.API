namespace CED.Data.Entities
{
    public class SalesTaxCode
    {
        public Guid StcId { get; set; }

        public byte[] StcTimeStamp { get; set; } = null!;

        public Guid StcLegalEntityId { get; set; }

        public Guid StcClientId { get; set; }

        public string StcTaxCodeId { get; set; } = null!;

        public DateTime StcEffectiveDate { get; set; }

        public DateTime? StcTerminationDate { get; set; }

        public DateTime StcCreatedDate { get; set; }

        public string? StcCreatedBy { get; set; }

        public DateTime StcLastModifiedDate { get; set; }

        public string? StcLastModifiedBy { get; set; }

        public virtual Client StcClient { get; set; } = null!;

        public virtual LegalEntity StcLegalEntity { get; set; } = null!;
    }
}