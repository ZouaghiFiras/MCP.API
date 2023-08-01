namespace CED.Data.Entities
{
    public class RecoveryPaymentStatus
    {
        public Guid RpsId { get; set; }

        public byte[] RpsTimeStamp { get; set; } = null!;

        public string RpsCode { get; set; } = null!;

        public string? RpsShortName { get; set; }

        public string RpsLongName { get; set; } = null!;

        public bool RpsInactive { get; set; }

        public Guid? RpsLocalizableEntryId { get; set; }

        public DateTime RpsCreatedDate { get; set; }

        public string? RpsCreatedBy { get; set; }

        public DateTime RpsLastModifiedDate { get; set; }

        public string? RpsLastModifiedBy { get; set; }

        public virtual ICollection<RecoveryPaymentStatusHistory> RecoveryPaymentStatusHistories { get; } =
            new List<RecoveryPaymentStatusHistory>();

        public virtual LocalizableEntry? RpsLocalizableEntry { get; set; }
    }
}