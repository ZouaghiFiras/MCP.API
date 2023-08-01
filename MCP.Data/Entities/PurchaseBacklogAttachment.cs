namespace CED.Data.Entities
{
    public class PurchaseBacklogAttachment
    {
        public Guid PbaId { get; set; }

        public byte[] PbaTimeStamp { get; set; } = null!;

        public Guid PbaPurchaseBacklogId { get; set; }

        public Guid PbaDocumentId { get; set; }

        public int PbaSequenceNumber { get; set; }

        public DateTime PbaCreatedDate { get; set; }

        public string? PbaCreatedBy { get; set; }

        public DateTime PbaLastModifiedDate { get; set; }

        public string? PbaLastModifiedBy { get; set; }

        public virtual Document PbaDocument { get; set; } = null!;

        public virtual PurchaseBacklog PbaPurchaseBacklog { get; set; } = null!;
    }
}