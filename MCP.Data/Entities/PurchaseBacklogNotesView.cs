namespace CED.Data.Entities
{
    public class PurchaseBacklogNotesView
    {
        public Guid Id { get; set; }

        public Guid PurchaseBacklogId { get; set; }

        public string Notes { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}