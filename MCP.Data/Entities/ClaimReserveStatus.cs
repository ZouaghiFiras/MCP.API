namespace CED.Data.Entities
{
    public class ClaimReserveStatus
    {
        public Guid RvsId { get; set; }

        public byte[] RvsTimeStamp { get; set; } = null!;

        public string RvsCode { get; set; } = null!;

        public string? RvsShortName { get; set; }

        public string RvsLongName { get; set; } = null!;

        public bool RvsInactive { get; set; }

        public Guid? RvsLocalizableEntryId { get; set; }

        public DateTime RvsCreatedDate { get; set; }

        public string? RvsCreatedBy { get; set; }

        public DateTime RvsLastModifiedDate { get; set; }

        public string? RvsLastModifiedBy { get; set; }

        public virtual ICollection<ClaimReserveStatusHistory> ClaimReserveStatusHistories { get; } =
            new List<ClaimReserveStatusHistory>();

        public virtual LocalizableEntry? RvsLocalizableEntry { get; set; }
    }
}