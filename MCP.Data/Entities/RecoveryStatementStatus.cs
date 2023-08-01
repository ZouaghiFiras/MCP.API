namespace CED.Data.Entities
{
    public class RecoveryStatementStatus
    {
        public Guid RssId { get; set; }

        public byte[] RssTimeStamp { get; set; } = null!;

        public string RssCode { get; set; } = null!;

        public string? RssShortName { get; set; }

        public string RssLongName { get; set; } = null!;

        public bool RssInactive { get; set; }

        public Guid? RssLocalizableEntryId { get; set; }

        public DateTime RssCreatedDate { get; set; }

        public string? RssCreatedBy { get; set; }

        public DateTime RssLastModifiedDate { get; set; }

        public string? RssLastModifiedBy { get; set; }

        public virtual ICollection<RecoveryStatementStatusHistory> RecoveryStatementStatusHistories { get; } =
            new List<RecoveryStatementStatusHistory>();

        public virtual LocalizableEntry? RssLocalizableEntry { get; set; }
    }
}