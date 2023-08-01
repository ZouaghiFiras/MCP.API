namespace CED.Data.Entities
{
    public class DossierOperationalStatusType
    {
        public string DstId { get; set; } = null!;

        public byte[] DstTimeStamp { get; set; } = null!;

        public string DstName { get; set; } = null!;

        public bool DstInactive { get; set; }

        public Guid? DstLocalizableEntryId { get; set; }

        public DateTime DstCreatedDate { get; set; }

        public string? DstCreatedBy { get; set; }

        public DateTime DstLastModifiedDate { get; set; }

        public string? DstLastModifiedBy { get; set; }

        public virtual ICollection<DossierOperationalStatus> DossierOperationalStatuses { get; } =
            new List<DossierOperationalStatus>();

        public virtual LocalizableEntry? DstLocalizableEntry { get; set; }
    }
}