namespace CED.Data.Entities
{
    public class TimeSlot
    {
        public Guid TmsId { get; set; }

        public byte[] TmsTimeStamp { get; set; } = null!;

        public TimeSpan TmsStartTime { get; set; }

        public TimeSpan TmsEndTime { get; set; }

        public bool TmsInactive { get; set; }

        public DateTime TmsCreatedDate { get; set; }

        public string? TmsCreatedBy { get; set; }

        public DateTime TmsLastModifiedDate { get; set; }

        public string? TmsLastModifiedBy { get; set; }

        public virtual ICollection<TimeTableSlot> TimeTableSlots { get; } = new List<TimeTableSlot>();
    }
}