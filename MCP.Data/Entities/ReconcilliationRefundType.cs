namespace CED.Data.Entities
{
    public class ReconcilliationRefundType
    {
        public short RftId { get; set; }

        public byte[] RftTimeStamp { get; set; } = null!;

        public string? RftAbbreviation { get; set; }

        public string RftDescription { get; set; } = null!;

        public bool RftInactive { get; set; }

        public Guid? RftLocalizableEntryId { get; set; }

        public DateTime RftCreatedDate { get; set; }

        public string? RftCreatedBy { get; set; }

        public DateTime RftLastModifiedDate { get; set; }

        public string? RftLastModifiedBy { get; set; }

        public virtual ICollection<ReconcilliationRefundAccount> ReconcilliationRefundAccounts { get; } =
            new List<ReconcilliationRefundAccount>();

        public virtual LocalizableEntry? RftLocalizableEntry { get; set; }
    }
}