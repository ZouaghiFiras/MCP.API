namespace CED.Data.Entities
{
    public class FixedCostAgreement
    {
        public Guid FcaId { get; set; }

        public byte[] FcaTimeStamp { get; set; } = null!;

        public decimal FcaFixedCostAmount { get; set; }

        public decimal? FcaFixedCostMarginAmount { get; set; }

        public double? FcaOrderTotalMarginPercentage { get; set; }

        public decimal? FcaOrderTotalMarginAmount { get; set; }

        public DateTime FcaCreatedDate { get; set; }

        public string? FcaCreatedBy { get; set; }

        public DateTime FcaLastModifiedDate { get; set; }

        public string? FcaLastModifiedBy { get; set; }

        public virtual CostAgreement Fca { get; set; } = null!;
    }
}