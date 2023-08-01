namespace CED.Data.Entities
{
    public class ClaimReserveWorkingOrder
    {
        public Guid CwoId { get; set; }

        public byte[] CwoTimeStamp { get; set; } = null!;

        public Guid CwoClaimReserveId { get; set; }

        public Guid CwoWorkingOrderLineCostId { get; set; }

        public bool CwoInactive { get; set; }

        public DateTime? CwoInactiveDate { get; set; }

        public DateTime CwoCreatedDate { get; set; }

        public string? CwoCreatedBy { get; set; }

        public DateTime CwoLastModifiedDate { get; set; }

        public string? CwoLastModifiedBy { get; set; }

        public virtual ClaimReserf CwoClaimReserve { get; set; } = null!;

        public virtual WorkingOrderLineCost CwoWorkingOrderLineCost { get; set; } = null!;
    }
}