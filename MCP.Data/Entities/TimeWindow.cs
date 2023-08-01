namespace CED.Data.Entities
{
    public class TimeWindow
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Guid TimeWindowListId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public virtual TimeWindowList TimeWindowList { get; set; } = null!;
    }
}