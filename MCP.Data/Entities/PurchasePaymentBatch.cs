namespace CED.Data.Entities
{
    public class PurchasePaymentBatch
    {
        public Guid PpbId { get; set; }

        public byte[] PpbTimeStamp { get; set; } = null!;

        public string PpbBatchNumber { get; set; } = null!;

        public Guid PpbEmployeeId { get; set; }

        public DateTime PpbCreatedDate { get; set; }

        public string? PpbCreatedBy { get; set; }

        public DateTime PpbLastModifiedDate { get; set; }

        public string? PpbLastModifiedBy { get; set; }

        public virtual Employee PpbEmployee { get; set; } = null!;

        public virtual ICollection<PurchasePaymentBatchLine> PurchasePaymentBatchLines { get; } =
            new List<PurchasePaymentBatchLine>();
    }
}