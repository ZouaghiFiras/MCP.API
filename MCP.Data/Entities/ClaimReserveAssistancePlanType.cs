namespace CED.Data.Entities
{
    public class ClaimReserveAssistancePlanType
    {
        public Guid RapId { get; set; }

        public byte[] RapTimeStamp { get; set; } = null!;

        public Guid RapClaimReserveTypeId { get; set; }

        public Guid RapAssistancePlanTypeId { get; set; }

        public bool RapInactive { get; set; }

        public DateTime RapCreatedDate { get; set; }

        public string? RapCreatedBy { get; set; }

        public DateTime RapLastModifiedDate { get; set; }

        public string? RapLastModifiedBy { get; set; }

        public virtual AssistancePlanType RapAssistancePlanType { get; set; } = null!;

        public virtual ClaimReserveType RapClaimReserveType { get; set; } = null!;
    }
}