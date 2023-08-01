namespace CED.Data.Entities
{
    public class ClaimReserveAssistancePlan
    {
        public Guid CapId { get; set; }

        public byte[] CapTimeStamp { get; set; } = null!;

        public Guid CapClaimReserveId { get; set; }

        public Guid CapAssistancePlanLineId { get; set; }

        public bool CapInactive { get; set; }

        public DateTime? CapInactiveDate { get; set; }

        public DateTime CapCreatedDate { get; set; }

        public string? CapCreatedBy { get; set; }

        public DateTime CapLastModifiedDate { get; set; }

        public string? CapLastModifiedBy { get; set; }

        public virtual AssistancePlanLine CapAssistancePlanLine { get; set; } = null!;

        public virtual ClaimReserf CapClaimReserve { get; set; } = null!;
    }
}