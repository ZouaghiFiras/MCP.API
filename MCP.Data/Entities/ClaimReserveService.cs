namespace CED.Data.Entities
{
    public class ClaimReserveService
    {
        public Guid CrsId { get; set; }

        public byte[] CrsTimeStamp { get; set; } = null!;

        public string CrsClaimReserveClassificationId { get; set; } = null!;

        public bool CrsInactive { get; set; }

        public DateTime CrsCreatedDate { get; set; }

        public string? CrsCreatedBy { get; set; }

        public DateTime CrsLastModifiedDate { get; set; }

        public string? CrsLastModifiedBy { get; set; }

        public virtual Service Crs { get; set; } = null!;

        public virtual ClaimReserveClassification CrsClaimReserveClassification { get; set; } = null!;
    }
}