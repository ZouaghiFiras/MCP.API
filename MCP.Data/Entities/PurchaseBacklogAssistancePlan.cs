namespace CED.Data.Entities
{
    public class PurchaseBacklogAssistancePlan
    {
        public Guid PbapId { get; set; }

        public byte[] PbapTimeStamp { get; set; } = null!;

        public Guid PbapPurchaseBacklogId { get; set; }

        public Guid PbapAssistancePlanId { get; set; }

        public bool PbapInactive { get; set; }

        public DateTime PbapCreatedDate { get; set; }

        public string? PbapCreatedBy { get; set; }

        public DateTime PbapLastModifiedDate { get; set; }

        public string? PbapLastModifiedBy { get; set; }

        public virtual AssistancePlan PbapAssistancePlan { get; set; } = null!;

        public virtual PurchaseBacklog PbapPurchaseBacklog { get; set; } = null!;
    }
}