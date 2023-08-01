namespace CED.Data.Entities
{
    public class ExchangeRateType
    {
        public string ErtId { get; set; } = null!;

        public byte[] ErtTimeStamp { get; set; } = null!;

        public string ErtName { get; set; } = null!;

        public bool ErtInactive { get; set; }

        public Guid? ErtLocalizableEntryId { get; set; }

        public DateTime ErtCreatedDate { get; set; }

        public string? ErtCreatedBy { get; set; }

        public DateTime ErtLastModifiedDate { get; set; }

        public string? ErtLastModifiedBy { get; set; }

        public virtual ICollection<CostFeeSettlement> CostFeeSettlements { get; } = new List<CostFeeSettlement>();

        public virtual LocalizableEntry? ErtLocalizableEntry { get; set; }

        public virtual ICollection<FeeSettlement> FeeSettlements { get; } = new List<FeeSettlement>();
    }
}