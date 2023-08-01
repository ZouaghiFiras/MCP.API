namespace CED.Data.Entities
{
    public class TaskCompletion
    {
        public Guid TascId { get; set; }

        public byte[] TascTimeStamp { get; set; } = null!;

        public Guid TascTaskId { get; set; }

        public Guid TascEmployeeId { get; set; }

        public DateTime TascCompletionDate { get; set; }

        public bool TascIsCanceled { get; set; }

        public DateTime TascCreatedDate { get; set; }

        public string? TascCreatedBy { get; set; }

        public DateTime TascLastModifiedDate { get; set; }

        public string? TascLastModifiedBy { get; set; }

        public virtual Employee TascEmployee { get; set; } = null!;

        public virtual Task TascTask { get; set; } = null!;
    }
}