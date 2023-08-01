namespace CED.Data.Entities
{
    public class FeeSettlementStatusHistory
    {
        public Guid FshId { get; set; }

        public byte[] FshTimeStamp { get; set; } = null!;

        public Guid FshFeeSettlementId { get; set; }

        public Guid FshFeeSettlementStatusId { get; set; }

        public DateTime FshStartDate { get; set; }

        public DateTime FshCreatedDate { get; set; }

        public string? FshCreatedBy { get; set; }

        public DateTime FshLastModifiedDate { get; set; }

        public string? FshLastModifiedBy { get; set; }

        public string? FshStatusChangeReason { get; set; }

        public virtual FeeSettlement FshFeeSettlement { get; set; } = null!;

        public virtual FeeSettlementStatus FshFeeSettlementStatus { get; set; } = null!;
    }
}