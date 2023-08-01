namespace CED.Data.Entities
{
    public class SalesAgreement
    {
        public Guid SgrId { get; set; }

        public byte[] SgrTimeStamp { get; set; } = null!;

        public Guid SgrSalesAgreementTypeId { get; set; }

        public string SgrCurrencyCode { get; set; } = null!;

        public DateTime SgrEffectiveDate { get; set; }

        public DateTime? SgrTerminationDate { get; set; }

        public bool SgrIncludingTax { get; set; }

        public string? SgrAgreementCode { get; set; }

        public string? SgrAgreementName { get; set; }

        public DateTime SgrCreatedDate { get; set; }

        public string? SgrCreatedBy { get; set; }

        public DateTime SgrLastModifiedDate { get; set; }

        public string? SgrLastModifiedBy { get; set; }

        public virtual FixedSalesAgreement? FixedSalesAgreement { get; set; }

        public virtual ICollection<SalesSettlementLine> SalesSettlementLines { get; } = new List<SalesSettlementLine>();

        public virtual SalesAgreementType SgrSalesAgreementType { get; set; } = null!;

        public virtual ICollection<VolumeSalesAgreement> VolumeSalesAgreements { get; } =
            new List<VolumeSalesAgreement>();
    }
}