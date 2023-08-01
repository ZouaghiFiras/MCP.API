namespace CED.Data.Entities
{
    public class FeeSettlementLineOperationalClient
    {
        public Guid FlsocId { get; set; }

        public Guid FlsocClientId { get; set; }

        public Guid FlsocFeeSettlementLineId { get; set; }

        public byte[] FlsocTimeStamp { get; set; } = null!;

        public DateTime FlsocStartDate { get; set; }

        public DateTime? FlsocEndDate { get; set; }

        public string? FlsocCreatedBy { get; set; }

        public DateTime FlsocCreatedDate { get; set; }

        public string? FlsocLastModifiedBy { get; set; }

        public DateTime FlsocLastModifiedDate { get; set; }

        public virtual Client FlsocClient { get; set; } = null!;

        public virtual FeeSettlementLine FlsocFeeSettlementLine { get; set; } = null!;
    }
}