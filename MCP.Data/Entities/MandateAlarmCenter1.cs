namespace CED.Data.Entities
{
    public class MandateAlarmCenter1
    {
        public Guid MacId { get; set; }

        public byte[] MacTimeStamp { get; set; } = null!;

        public Guid MacMandateId { get; set; }

        public Guid MacAlarmCenterId { get; set; }

        public bool MacInactive { get; set; }

        public DateTime MacCreatedDate { get; set; }

        public string? MacCreatedBy { get; set; }

        public DateTime MacLastModifiedDate { get; set; }

        public string? MacLastModifiedBy { get; set; }
    }
}