namespace CED.Data.Entities
{
    public class PurchaseBacklogNote
    {
        public Guid PbnId { get; set; }

        public byte[] PbnTimeStamp { get; set; } = null!;

        public Guid PbnPurchaseBacklogId { get; set; }

        public string PbnNotes { get; set; } = null!;

        public DateTime PbnCreatedDate { get; set; }

        public string? PbnCreatedBy { get; set; }

        public DateTime PbnLastModifiedDate { get; set; }

        public string? PbnLastModifiedBy { get; set; }

        public virtual PurchaseBacklog PbnPurchaseBacklog { get; set; } = null!;
    }
}