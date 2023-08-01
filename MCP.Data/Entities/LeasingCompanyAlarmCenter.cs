namespace CED.Data.Entities
{
    public class LeasingCompanyAlarmCenter
    {
        public Guid LcaId { get; set; }

        public byte[] LcaTimeStamp { get; set; } = null!;

        public Guid LcaLeasingCompanyId { get; set; }

        public Guid LcaAlarmCenterId { get; set; }

        public bool LcaInactive { get; set; }

        public DateTime LcaCreatedDate { get; set; }

        public string? LcaCreatedBy { get; set; }

        public DateTime LcaLastModifiedDate { get; set; }

        public string? LcaLastModifiedBy { get; set; }

        public virtual AlarmCenter LcaAlarmCenter { get; set; } = null!;

        public virtual LeasingCompany LcaLeasingCompany { get; set; } = null!;
    }
}