namespace CED.Data.Entities
{
    public class TimeTable
    {
        public Guid TmtId { get; set; }

        public byte[] TmtTimeStamp { get; set; } = null!;

        public string TmtCode { get; set; } = null!;

        public string? TmtShortName { get; set; }

        public string TmtLongName { get; set; } = null!;

        public bool TmtInactive { get; set; }

        public DateTime TmtCreatedDate { get; set; }

        public string? TmtCreatedBy { get; set; }

        public DateTime TmtLastModifiedDate { get; set; }

        public string? TmtLastModifiedBy { get; set; }

        public virtual ICollection<AppointmentTimeSlot> AppointmentTimeSlots { get; } = new List<AppointmentTimeSlot>();

        public virtual ICollection<TimeTableSlot> TimeTableSlots { get; } = new List<TimeTableSlot>();
    }
}