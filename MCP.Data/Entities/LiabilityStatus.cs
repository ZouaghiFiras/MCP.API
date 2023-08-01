namespace CED.Data.Entities
{
    public class LiabilityStatus
    {
        public Guid LstId { get; set; }

        public byte[] LstTimeStamp { get; set; } = null!;

        public string LstCode { get; set; } = null!;

        public string? LstShortName { get; set; }

        public string LstLongName { get; set; } = null!;

        public bool LstInactive { get; set; }

        public Guid? LstLocalizableEntryId { get; set; }

        public DateTime LstCreatedDate { get; set; }

        public string? LstCreatedBy { get; set; }

        public DateTime LstLastModifiedDate { get; set; }

        public string? LstLastModifiedBy { get; set; }

        public virtual ICollection<LiabilityStatusHistory> LiabilityStatusHistories { get; } =
            new List<LiabilityStatusHistory>();

        public virtual LocalizableEntry? LstLocalizableEntry { get; set; }
    }
}