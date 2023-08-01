namespace CED.Data.Entities
{
    public class FeeSettlementStatusType
    {
        public string FsstId { get; set; } = null!;

        public byte[] FsstTimeStamp { get; set; } = null!;

        public string FsstName { get; set; } = null!;

        public bool FsstInactive { get; set; }

        public Guid? FsstLocalizableEntryId { get; set; }

        public DateTime FsstCreatedDate { get; set; }

        public string? FsstCreatedBy { get; set; }

        public DateTime FsstLastModifiedDate { get; set; }

        public string? FsstLastModifiedBy { get; set; }

        public virtual ICollection<FeeSettlementStatus> FeeSettlementStatuses { get; } =
            new List<FeeSettlementStatus>();

        public virtual LocalizableEntry? FsstLocalizableEntry { get; set; }
    }
}