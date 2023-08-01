namespace CED.Data.Entities
{
    public class ClaimReserveStatusHistory
    {
        public Guid RvshId { get; set; }

        public byte[] RvshTimeStamp { get; set; } = null!;

        public Guid RvshClaimReserveId { get; set; }

        public Guid RvshClaimReserveStatusId { get; set; }

        public Guid RvshEmployeeId { get; set; }

        public DateTime RvshStartDate { get; set; }

        public string? RvshStatusChangeReason { get; set; }

        public short RvshStatusSource { get; set; }

        public DateTime RvshCreatedDate { get; set; }

        public string? RvshCreatedBy { get; set; }

        public DateTime RvshLastModifiedDate { get; set; }

        public string? RvshLastModifiedBy { get; set; }

        public virtual ClaimReserf RvshClaimReserve { get; set; } = null!;

        public virtual ClaimReserveStatus RvshClaimReserveStatus { get; set; } = null!;

        public virtual Employee RvshEmployee { get; set; } = null!;
    }
}