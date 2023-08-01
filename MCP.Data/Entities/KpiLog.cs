namespace CED.Data.Entities
{
    public class KpiLog
    {
        public Guid KdlId { get; set; }

        public byte[] KdlTimeStamp { get; set; } = null!;

        public Guid? KdlDossierId { get; set; }

        public Guid? KdlAssignmentId { get; set; }

        public Guid KdlKpiId { get; set; }

        public string KdlLogMessage { get; set; } = null!;

        public DateTime KdlCreatedDate { get; set; }

        public string? KdlCreatedBy { get; set; }

        public DateTime KdlLastModifiedDate { get; set; }

        public string? KdlLastModifiedBy { get; set; }
    }
}