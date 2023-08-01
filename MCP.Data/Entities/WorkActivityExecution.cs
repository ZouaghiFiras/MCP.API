namespace CED.Data.Entities
{
    public class WorkActivityExecution
    {
        public Guid WaeId { get; set; }

        public byte[] WaeTimeStamp { get; set; } = null!;

        public Guid WaeActivityExecutionId { get; set; }

        public Guid WaeWorkActivityId { get; set; }

        public DateTime WaeCreatedDate { get; set; }

        public string? WaeCreatedBy { get; set; }

        public DateTime WaeLastModifiedDate { get; set; }

        public string? WaeLastModifiedBy { get; set; }

        public virtual ActivityExecution WaeActivityExecution { get; set; } = null!;

        public virtual WorkActivity WaeWorkActivity { get; set; } = null!;
    }
}