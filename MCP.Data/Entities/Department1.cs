namespace CED.Data.Entities
{
    public class Department1
    {
        public Guid DepId { get; set; }

        public byte[] DepTimeStamp { get; set; } = null!;

        public Guid DepBusinessUnitId { get; set; }

        public Guid? DepProductLineId { get; set; }

        public Guid? DepCostUnitId { get; set; }

        public Guid? DepRegionId { get; set; }

        public DateTime DepCreatedDate { get; set; }

        public string? DepCreatedBy { get; set; }

        public DateTime DepLastModifiedDate { get; set; }

        public string? DepLastModifiedBy { get; set; }
    }
}