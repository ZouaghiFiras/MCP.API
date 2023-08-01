namespace CED.Data.Entities
{
    public class PurchaseOrderStatus
    {
        public Guid PosId { get; set; }

        public byte[] PosTimeStamp { get; set; } = null!;

        public string PosCode { get; set; } = null!;

        public string? PosShortName { get; set; }

        public string PosLongName { get; set; } = null!;

        public bool PosInactive { get; set; }

        public Guid? PosLocalizableEntryId { get; set; }

        public DateTime PosCreatedDate { get; set; }

        public string? PosCreatedBy { get; set; }

        public DateTime PosLastModifiedDate { get; set; }

        public string? PosLastModifiedBy { get; set; }

        public virtual LocalizableEntry? PosLocalizableEntry { get; set; }

        public virtual ICollection<PurchaseOrderStatusHistory> PurchaseOrderStatusHistories { get; } =
            new List<PurchaseOrderStatusHistory>();
    }
}