namespace CED.Data.Entities
{
    public class FixedFeeAgreement
    {
        public Guid FfaId { get; set; }

        public byte[] FfaTimeStamp { get; set; } = null!;

        public decimal FfaFixedFeeAmount { get; set; }

        public DateTime FfaCreatedDate { get; set; }

        public string? FfaCreatedBy { get; set; }

        public DateTime FfaLastModifiedDate { get; set; }

        public string? FfaLastModifiedBy { get; set; }

        public virtual FeeAgreement Ffa { get; set; } = null!;
    }
}