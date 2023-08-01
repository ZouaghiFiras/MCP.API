namespace CED.Data.Entities
{
    public class FeeAgreement
    {
        public Guid AgrId { get; set; }

        public byte[] AgrTimeStamp { get; set; } = null!;

        public Guid AgrFeeAgreementTypeId { get; set; }

        public string AgrCurrencyCode { get; set; } = null!;

        public DateTime AgrEffectiveDate { get; set; }

        public DateTime? AgrTerminationDate { get; set; }

        public bool AgrIncludingTax { get; set; }

        public string? AgrAgreementName { get; set; }

        public DateTime AgrCreatedDate { get; set; }

        public string? AgrCreatedBy { get; set; }

        public DateTime AgrLastModifiedDate { get; set; }

        public string? AgrLastModifiedBy { get; set; }

        public Guid? AgrFollowUpAgreementId { get; set; }

        public virtual FeeAgreementType AgrFeeAgreementType { get; set; } = null!;

        public virtual CostFeeAgreement? CostFeeAgreement { get; set; }

        public virtual ICollection<FeeSettlementLine> FeeSettlementLines { get; } = new List<FeeSettlementLine>();

        public virtual ICollection<FeeSettlementReportingFormOption> FeeSettlementReportingFormOptions { get; } =
            new List<FeeSettlementReportingFormOption>();

        public virtual FixedFeeAgreement? FixedFeeAgreement { get; set; }

        public virtual HourlyFeeAgreement? HourlyFeeAgreement { get; set; }

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();
    }
}