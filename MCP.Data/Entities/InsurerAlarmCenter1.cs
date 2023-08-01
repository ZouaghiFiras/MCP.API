namespace CED.Data.Entities
{
    public class InsurerAlarmCenter1
    {
        public Guid IacId { get; set; }

        public byte[] IacTimeStamp { get; set; } = null!;

        public Guid IacInsurerId { get; set; }

        public Guid IacAlarmCenterId { get; set; }

        public bool IacInactive { get; set; }

        public DateTime IacCreatedDate { get; set; }

        public string? IacCreatedBy { get; set; }

        public DateTime IacLastModifiedDate { get; set; }

        public string? IacLastModifiedBy { get; set; }
    }
}