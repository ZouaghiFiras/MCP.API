namespace CED.Data.Entities
{
    public class FeeAgreementsView
    {
        public Guid Id { get; set; }

        public string? AgreementName { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public bool IncludingTax { get; set; }

        public Guid AgreementTypeId { get; set; }

        public string AgreementTypeName { get; set; } = null!;

        public decimal? Percentage { get; set; }

        public decimal? PercentageMinAmount { get; set; }

        public decimal? PercentageMaxAmount { get; set; }

        public decimal? FixedAmount { get; set; }

        public decimal? HourlyRate { get; set; }

        public string? UnitOfMeasureId { get; set; }

        public string? UnitOfMeasure { get; set; }

        public decimal? HourlyRateMinAmount { get; set; }

        public decimal? HourlyRateMaxAmount { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}