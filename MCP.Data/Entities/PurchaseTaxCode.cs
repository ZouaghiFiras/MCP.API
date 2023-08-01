namespace CED.Data.Entities
{
    public class PurchaseTaxCode
    {
        public Guid PtcId { get; set; }

        public byte[] PtcTimeStamp { get; set; } = null!;

        public Guid PtcLegalEntityId { get; set; }

        public Guid PtcSupplierId { get; set; }

        public string PtcTaxCodeId { get; set; } = null!;

        public DateTime PtcEffectiveDate { get; set; }

        public DateTime? PtcTerminationDate { get; set; }

        public DateTime PtcCreatedDate { get; set; }

        public string? PtcCreatedBy { get; set; }

        public DateTime PtcLastModifiedDate { get; set; }

        public string? PtcLastModifiedBy { get; set; }

        public virtual LegalEntity PtcLegalEntity { get; set; } = null!;

        public virtual Supplier PtcSupplier { get; set; } = null!;
    }
}