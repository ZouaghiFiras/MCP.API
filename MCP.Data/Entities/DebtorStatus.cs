namespace CED.Data.Entities
{
    public class DebtorStatus
    {
        public Guid DbsId { get; set; }

        public byte[] DbsTimeStamp { get; set; } = null!;

        public string DbsCode { get; set; } = null!;

        public string? DbsShortName { get; set; }

        public string DbsLongName { get; set; } = null!;

        public bool DbsInactive { get; set; }

        public Guid? DbsLocalizableEntryId { get; set; }

        public DateTime DbsCreatedDate { get; set; }

        public string? DbsCreatedBy { get; set; }

        public DateTime DbsLastModifiedDate { get; set; }

        public string? DbsLastModifiedBy { get; set; }

        public virtual LocalizableEntry? DbsLocalizableEntry { get; set; }

        public virtual ICollection<DebtorStatusHistory> DebtorStatusHistories { get; } =
            new List<DebtorStatusHistory>();
    }
}