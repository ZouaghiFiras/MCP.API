namespace CED.Data.Entities
{
    public class OvsPayment
    {
        public Guid OpaId { get; set; }

        public byte[] OpaTimeStamp { get; set; } = null!;

        public Guid OpaOvsRegresId { get; set; }

        public Guid? OpaOvsMessageIncomingId { get; set; }

        public Guid? OpaOvsMessageOutgoingId { get; set; }

        public int? OpaSequenceNumber { get; set; }

        public bool? OpaIsSebsequentMessage { get; set; }

        public bool? OpaIsOwnAmount { get; set; }

        public int OpaSettlementNumber { get; set; }

        public decimal OpaAmountPayment { get; set; }

        public Guid? OpaCostTypeId { get; set; }

        public DateTime OpaCreatedDate { get; set; }

        public string? OpaCreatedBy { get; set; }

        public DateTime OpaLastModifiedDate { get; set; }

        public string? OpaLastModifiedBy { get; set; }

        public virtual CostType? OpaCostType { get; set; }

        public virtual OvsMessageIncoming? OpaOvsMessageIncoming { get; set; }

        public virtual OvsMessageOutgoing? OpaOvsMessageOutgoing { get; set; }

        public virtual OvsRegre OpaOvsRegres { get; set; } = null!;
    }
}