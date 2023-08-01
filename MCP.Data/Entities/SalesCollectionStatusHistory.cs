namespace CED.Data.Entities
{
    public class SalesCollectionStatusHistory
    {
        public Guid ScshId { get; set; }

        public byte[] ScshTimeStamp { get; set; } = null!;

        public Guid ScshSalesCollectionId { get; set; }

        public Guid ScshSalesCollectionStatusId { get; set; }

        public DateTime ScshStartDate { get; set; }

        public string? ScshStatusChangeReason { get; set; }

        public DateTime ScshCreatedDate { get; set; }

        public string? ScshCreatedBy { get; set; }

        public DateTime ScshLastModifiedDate { get; set; }

        public string? ScshLastModifiedBy { get; set; }

        public virtual SalesCollection ScshSalesCollection { get; set; } = null!;

        public virtual SalesCollectionStatus ScshSalesCollectionStatus { get; set; } = null!;
    }
}