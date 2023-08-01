namespace CED.Data.Entities
{
    public class FeeSettlementsView
    {
        public Guid Id { get; set; }

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public Guid? ClientId { get; set; }

        public string? ClientCode { get; set; }

        public string ClientName { get; set; } = null!;

        public int LineNumber { get; set; }

        public Guid ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public Guid? CoverageId { get; set; }

        public string? CoverageName { get; set; }

        public Guid? WorkActivityId { get; set; }

        public string? WorkActivityName { get; set; }

        public Guid? ActivityExecutionId { get; set; }

        public string? ActivityExecutionName { get; set; }

        public Guid? ActivityOptionId { get; set; }

        public string? ActivityOptionName { get; set; }

        public Guid AgreementId { get; set; }

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