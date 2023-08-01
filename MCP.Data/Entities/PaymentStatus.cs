namespace CED.Data.Entities
{
    public class PaymentStatus
    {
        public Guid PstId { get; set; }

        public byte[] PstTimeStamp { get; set; } = null!;

        public string PstCode { get; set; } = null!;

        public string? PstShortName { get; set; }

        public string PstLongName { get; set; } = null!;

        public bool PstInactive { get; set; }

        public Guid? PstLocalizableEntryId { get; set; }

        public DateTime PstCreatedDate { get; set; }

        public string? PstCreatedBy { get; set; }

        public DateTime PstLastModifiedDate { get; set; }

        public string? PstLastModifiedBy { get; set; }

        public virtual ICollection<PaymentStatusHistory> PaymentStatusHistories { get; } =
            new List<PaymentStatusHistory>();

        public virtual LocalizableEntry? PstLocalizableEntry { get; set; }
    }
}