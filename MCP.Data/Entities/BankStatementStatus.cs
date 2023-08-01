namespace CED.Data.Entities
{
    public class BankStatementStatus
    {
        public Guid BssId { get; set; }

        public byte[] BssTimeStamp { get; set; } = null!;

        public string BssCode { get; set; } = null!;

        public string? BssShortName { get; set; }

        public string BssLongName { get; set; } = null!;

        public bool BssInactive { get; set; }

        public Guid? BssLocalizableEntryId { get; set; }

        public DateTime BssCreatedDate { get; set; }

        public string? BssCreatedBy { get; set; }

        public DateTime BssLastModifiedDate { get; set; }

        public string? BssLastModifiedBy { get; set; }

        public virtual ICollection<BankStatementStatusHistory> BankStatementStatusHistories { get; } =
            new List<BankStatementStatusHistory>();

        public virtual LocalizableEntry? BssLocalizableEntry { get; set; }
    }
}