namespace CED.Data.Entities
{
    public class JournalEntryStatusHistory
    {
        public Guid JeshId { get; set; }

        public byte[] JeshTimeStamp { get; set; } = null!;

        public Guid JeshJournalEntryId { get; set; }

        public Guid JeshJournalEntryStatusId { get; set; }

        public Guid? JeshEmployeeId { get; set; }

        public DateTime JeshStartDate { get; set; }

        public string? JeshStatusChangeReason { get; set; }

        public short JeshStatusSource { get; set; }

        public DateTime JeshCreatedDate { get; set; }

        public string? JeshCreatedBy { get; set; }

        public DateTime JeshLastModifiedDate { get; set; }

        public string? JeshLastModifiedBy { get; set; }

        public virtual Employee? JeshEmployee { get; set; }

        public virtual JournalEntry JeshJournalEntry { get; set; } = null!;

        public virtual JournalEntryStatus JeshJournalEntryStatus { get; set; } = null!;
    }
}