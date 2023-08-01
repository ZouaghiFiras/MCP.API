namespace CED.Data.Entities
{
    public class SalesCollectionNote
    {
        public Guid ScnId { get; set; }

        public byte[] ScnTimeStamp { get; set; } = null!;

        public Guid ScnSalesCollectionId { get; set; }

        public string ScnNotes { get; set; } = null!;

        public DateTime ScnCreatedDate { get; set; }

        public string? ScnCreatedBy { get; set; }

        public DateTime ScnLastModifiedDate { get; set; }

        public string? ScnLastModifiedBy { get; set; }

        public virtual SalesCollection ScnSalesCollection { get; set; } = null!;
    }
}