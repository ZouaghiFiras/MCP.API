namespace CED.Data.Entities
{
    public class SummaryStatementCreationMethod
    {
        public string SsmId { get; set; } = null!;

        public byte[]? SsmTimeStamp { get; set; }

        public string? SsmDescription { get; set; }

        public bool SsmInactive { get; set; }

        public Guid? SsmLocalizableEntryId { get; set; }

        public DateTime SsmCreatedDate { get; set; }

        public string? SsmCreatedBy { get; set; }

        public DateTime SsmLastModifiedDate { get; set; }

        public string? SsmLastModifiedBy { get; set; }

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();

        public virtual LocalizableEntry? SsmLocalizableEntry { get; set; }
    }
}