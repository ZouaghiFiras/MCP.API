namespace CED.Data.Entities
{
    public class Claim
    {
        public Guid ClmId { get; set; }

        public byte[] ClmTimeStamp { get; set; } = null!;

        public Guid ClmPaymentId { get; set; }

        public Guid ClmCostTypeId { get; set; }

        public decimal ClmClaimAmount { get; set; }

        public DateTime ClmCreatedDate { get; set; }

        public string? ClmCreatedBy { get; set; }

        public DateTime ClmLastModifiedDate { get; set; }

        public string? ClmLastModifiedBy { get; set; }

        public virtual CostType ClmCostType { get; set; } = null!;

        public virtual Payment ClmPayment { get; set; } = null!;

        public virtual ICollection<Retention> Retentions { get; } = new List<Retention>();
    }
}