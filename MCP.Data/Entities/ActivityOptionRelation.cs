namespace CED.Data.Entities
{
    public class ActivityOptionRelation
    {
        public Guid AorId { get; set; }

        public byte[] AorTimeStamp { get; set; } = null!;

        public Guid? AorChildActivityExecutionId { get; set; }

        public Guid? AorParentActivityExecutionId { get; set; }

        public DateTime AorCreatedDate { get; set; }

        public string? AorCreatedBy { get; set; }

        public DateTime AorLastModifiedDate { get; set; }

        public string? AorLastModifiedBy { get; set; }

        public virtual ActivityOption? AorChildActivityExecution { get; set; }

        public virtual ActivityOption? AorParentActivityExecution { get; set; }
    }
}