namespace CED.Data.Entities
{
    public class CostOfSalesJournalEntryLine
    {
        public Guid OjlId { get; set; }

        public byte[] OjlTimeStamp { get; set; } = null!;

        public Guid OjlCostOfSalesLineId { get; set; }

        public Guid OjlJournalEntryLineId { get; set; }

        public DateTime OjlCreatedDate { get; set; }

        public string? OjlCreatedBy { get; set; }

        public DateTime OjlLastModifiedDate { get; set; }

        public string? OjlLastModifiedBy { get; set; }

        public virtual CostOfSalesLine OjlCostOfSalesLine { get; set; } = null!;

        public virtual JournalEntryLine OjlJournalEntryLine { get; set; } = null!;
    }
}