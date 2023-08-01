namespace CED.Data.Entities
{
    public class ReconcilliationActionType
    {
        public short RatId { get; set; }

        public byte[] RatTimeStamp { get; set; } = null!;

        public string? RatAbbreviation { get; set; }

        public string RatDescription { get; set; } = null!;

        public bool RatInactive { get; set; }

        public Guid? RatLocalizableEntryId { get; set; }

        public DateTime RatCreatedDate { get; set; }

        public string? RatCreatedBy { get; set; }

        public DateTime RatLastModifiedDate { get; set; }

        public string? RatLastModifiedBy { get; set; }

        public virtual ICollection<BankStatementReconcilliation> BankStatementReconcilliations { get; } =
            new List<BankStatementReconcilliation>();

        public virtual LocalizableEntry? RatLocalizableEntry { get; set; }

        public virtual ICollection<ReconcilliationAction> ReconcilliationActions { get; } =
            new List<ReconcilliationAction>();
    }
}