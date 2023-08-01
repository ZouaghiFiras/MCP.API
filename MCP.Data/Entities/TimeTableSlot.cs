namespace CED.Data.Entities
{
    public class TimeTableSlot
    {
        public Guid TslId { get; set; }

        public byte[] TslTimeStamp { get; set; } = null!;

        public Guid TslTimeTableId { get; set; }

        public Guid TslTimeSlotId { get; set; }

        public bool TslInactive { get; set; }

        public DateTime TslCreatedDate { get; set; }

        public string? TslCreatedBy { get; set; }

        public DateTime TslLastModifiedDate { get; set; }

        public string? TslLastModifiedBy { get; set; }

        public virtual TimeSlot TslTimeSlot { get; set; } = null!;

        public virtual TimeTable TslTimeTable { get; set; } = null!;
    }
}