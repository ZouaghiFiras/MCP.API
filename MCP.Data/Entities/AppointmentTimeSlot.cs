namespace CED.Data.Entities
{
    public class AppointmentTimeSlot
    {
        public Guid PtsId { get; set; }

        public byte[] PtsTimeStamp { get; set; } = null!;

        public Guid PtsProductId { get; set; }

        public Guid PtsTimeTableId { get; set; }

        public DateTime PtsCreatedDate { get; set; }

        public string? PtsCreatedBy { get; set; }

        public DateTime PtsLastModifiedDate { get; set; }

        public string? PtsLastModifiedBy { get; set; }

        public virtual Product PtsProduct { get; set; } = null!;

        public virtual TimeTable PtsTimeTable { get; set; } = null!;
    }
}