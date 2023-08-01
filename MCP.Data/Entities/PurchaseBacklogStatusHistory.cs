namespace CED.Data.Entities
{
    public class PurchaseBacklogStatusHistory
    {
        public Guid PbshId { get; set; }

        public byte[] PbshTimeStamp { get; set; } = null!;

        public Guid PbshPurchaseBacklogId { get; set; }

        public Guid PbshPurchaseBacklogStatusId { get; set; }

        public Guid? PbshEmployeeId { get; set; }

        public DateTime PbshStartDate { get; set; }

        public DateTime PbshCreatedDate { get; set; }

        public string? PbshCreatedBy { get; set; }

        public DateTime PbshLastModifiedDate { get; set; }

        public string? PbshLastModifiedBy { get; set; }

        public virtual Employee? PbshEmployee { get; set; }

        public virtual PurchaseBacklog PbshPurchaseBacklog { get; set; } = null!;

        public virtual PurchaseBacklogStatus PbshPurchaseBacklogStatus { get; set; } = null!;
    }
}