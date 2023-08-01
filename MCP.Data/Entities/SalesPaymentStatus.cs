namespace CED.Data.Entities
{
    public class SalesPaymentStatus
    {
        public Guid SpsId { get; set; }

        public byte[] SpsTimeStamp { get; set; } = null!;

        public string SpsCode { get; set; } = null!;

        public string? SpsShortName { get; set; }

        public string SpsLongName { get; set; } = null!;

        public bool SpsInactive { get; set; }

        public Guid? SpsLocalizableEntryId { get; set; }

        public DateTime SpsCreatedDate { get; set; }

        public string? SpsCreatedBy { get; set; }

        public DateTime SpsLastModifiedDate { get; set; }

        public string? SpsLastModifiedBy { get; set; }

        public virtual ICollection<SalesPaymentStatusHistory> SalesPaymentStatusHistories { get; } =
            new List<SalesPaymentStatusHistory>();

        public virtual LocalizableEntry? SpsLocalizableEntry { get; set; }
    }
}