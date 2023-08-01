namespace CED.Data.Entities
{
    public class FundingsPaymentStatus
    {
        public Guid FpsId { get; set; }

        public byte[] FpsTimeStamp { get; set; } = null!;

        public string FpsCode { get; set; } = null!;

        public string? FpsShortName { get; set; }

        public string FpsLongName { get; set; } = null!;

        public bool FpsInactive { get; set; }

        public Guid? FpsLocalizableEntryId { get; set; }

        public DateTime FpsCreatedDate { get; set; }

        public string? FpsCreatedBy { get; set; }

        public DateTime FpsLastModifiedDate { get; set; }

        public string? FpsLastModifiedBy { get; set; }

        public virtual LocalizableEntry? FpsLocalizableEntry { get; set; }

        public virtual ICollection<FundingsPaymentStatusHistory> FundingsPaymentStatusHistories { get; } =
            new List<FundingsPaymentStatusHistory>();
    }
}