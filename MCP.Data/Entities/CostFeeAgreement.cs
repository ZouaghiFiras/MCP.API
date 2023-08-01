namespace CED.Data.Entities
{
    public class CostFeeAgreement
    {
        public Guid CfaId { get; set; }

        public byte[] CfaTimeStamp { get; set; } = null!;

        public decimal CfaFeePercentage { get; set; }

        public decimal CfaMinFeeAmount { get; set; }

        public decimal? CfaMaxFeeAmount { get; set; }

        public DateTime CfaCreatedDate { get; set; }

        public string? CfaCreatedBy { get; set; }

        public DateTime CfaLastModifiedDate { get; set; }

        public string? CfaLastModifiedBy { get; set; }

        public virtual FeeAgreement Cfa { get; set; } = null!;
    }
}