namespace CED.Data.Entities
{
    public class ClaimReserveClassification
    {
        public string CrcId { get; set; } = null!;

        public byte[] CrcTimeStamp { get; set; } = null!;

        public string CrcName { get; set; } = null!;

        public bool CrcInactive { get; set; }

        public Guid? CrcLocalizableEntryId { get; set; }

        public DateTime CrcCreatedDate { get; set; }

        public string? CrcCreatedBy { get; set; }

        public DateTime CrcLastModifiedDate { get; set; }

        public string? CrcLastModifiedBy { get; set; }

        public virtual ICollection<ClaimReserveService> ClaimReserveServices { get; } = new List<ClaimReserveService>();

        public virtual ICollection<ClaimReserf> ClaimReserves { get; } = new List<ClaimReserf>();

        public virtual LocalizableEntry? CrcLocalizableEntry { get; set; }
    }
}