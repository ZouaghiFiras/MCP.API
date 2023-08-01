namespace CED.Data.Entities
{
    public class Retention
    {
        public Guid RtnId { get; set; }

        public byte[] RtnTimeStamp { get; set; } = null!;

        public Guid RtnClaimId { get; set; }

        public Guid RtnCostTypeId { get; set; }

        public int RtnSequenceNumber { get; set; }

        public decimal RtnRetentionAmount { get; set; }

        public DateTime RtnCreatedDate { get; set; }

        public string? RtnCreatedBy { get; set; }

        public DateTime RtnLastModifiedDate { get; set; }

        public string? RtnLastModifiedBy { get; set; }

        public virtual Claim RtnClaim { get; set; } = null!;

        public virtual CostType RtnCostType { get; set; } = null!;
    }
}