namespace CED.Data.Entities
{
    public class FeeSettlementStatus
    {
        public Guid FstId { get; set; }

        public byte[] FstTimeStamp { get; set; } = null!;

        public string FstCode { get; set; } = null!;

        public string? FstShortName { get; set; }

        public string FstLongName { get; set; } = null!;

        public bool FstInactive { get; set; }

        public Guid? FstLocalizableEntryId { get; set; }

        public DateTime FstCreatedDate { get; set; }

        public string? FstCreatedBy { get; set; }

        public DateTime FstLastModifiedDate { get; set; }

        public string? FstLastModifiedBy { get; set; }

        public string? FstFeeSettlementStatusTypeId { get; set; }

        public virtual ICollection<FeeSettlementStatusHistory> FeeSettlementStatusHistories { get; } =
            new List<FeeSettlementStatusHistory>();

        public virtual FeeSettlementStatusType? FstFeeSettlementStatusType { get; set; }

        public virtual LocalizableEntry? FstLocalizableEntry { get; set; }
    }
}