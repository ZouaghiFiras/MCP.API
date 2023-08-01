namespace CED.Data.Entities
{
    public class PurchasePaymentStatus
    {
        public Guid PpsId { get; set; }

        public byte[] PpsTimeStamp { get; set; } = null!;

        public string PpsCode { get; set; } = null!;

        public string? PpsShortName { get; set; }

        public string PpsLongName { get; set; } = null!;

        public bool PpsInactive { get; set; }

        public Guid? PpsLocalizableEntryId { get; set; }

        public DateTime PpsCreatedDate { get; set; }

        public string? PpsCreatedBy { get; set; }

        public DateTime PpsLastModifiedDate { get; set; }

        public string? PpsLastModifiedBy { get; set; }

        public virtual LocalizableEntry? PpsLocalizableEntry { get; set; }

        public virtual ICollection<PurchasePaymentStatusHistory> PurchasePaymentStatusHistories { get; } =
            new List<PurchasePaymentStatusHistory>();
    }
}