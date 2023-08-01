namespace CED.Data.Entities
{
    public class HourlyFeeAgreement
    {
        public Guid HfaId { get; set; }

        public byte[] HfaTimeStamp { get; set; } = null!;

        public decimal HfaHourlyFeeRate { get; set; }

        public decimal? HfaUnitPrice { get; set; }

        public string HfaUnitOfMeasureId { get; set; } = null!;

        public decimal HfaMinFeeAmount { get; set; }

        public decimal? HfaMaxFeeAmount { get; set; }

        public DateTime HfaCreatedDate { get; set; }

        public string? HfaCreatedBy { get; set; }

        public DateTime HfaLastModifiedDate { get; set; }

        public string? HfaLastModifiedBy { get; set; }

        public virtual FeeAgreement Hfa { get; set; } = null!;

        public virtual UnitOfMeasure HfaUnitOfMeasure { get; set; } = null!;
    }
}