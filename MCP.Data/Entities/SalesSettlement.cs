namespace CED.Data.Entities
{
    public class SalesSettlement
    {
        public Guid SstId { get; set; }

        public byte[] SstTimeStamp { get; set; } = null!;

        public string SstSettlementName { get; set; } = null!;

        public Guid? SstLegalEntityId { get; set; }

        public Guid? SstClientId { get; set; }

        public string? SstContractNumber { get; set; }

        public string? SstDiscountCode { get; set; }

        public DateTime SstCreatedDate { get; set; }

        public string? SstCreatedBy { get; set; }

        public DateTime SstLastModifiedDate { get; set; }

        public string? SstLastModifiedBy { get; set; }

        public string? SstEntrySystem { get; set; }

        public DateTime? SstEffectiveDate { get; set; }

        public DateTime? SstTerminationDate { get; set; }

        public virtual ICollection<SalesSettlementLine> SalesSettlementLines { get; } = new List<SalesSettlementLine>();

        public virtual Client? SstClient { get; set; }

        public virtual LegalEntity? SstLegalEntity { get; set; }
    }
}