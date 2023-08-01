namespace CED.Data.Entities
{
    public class PurchaseBacklogStatus
    {
        public Guid PbsId { get; set; }

        public byte[] PbsTimeStamp { get; set; } = null!;

        public string PbsCode { get; set; } = null!;

        public string? PbsShortName { get; set; }

        public string PbsLongName { get; set; } = null!;

        public bool PbsInactive { get; set; }

        public Guid? PbsLocalizableEntryId { get; set; }

        public DateTime PbsCreatedDate { get; set; }

        public string? PbsCreatedBy { get; set; }

        public DateTime PbsLastModifiedDate { get; set; }

        public string? PbsLastModifiedBy { get; set; }

        public virtual LocalizableEntry? PbsLocalizableEntry { get; set; }

        public virtual ICollection<PurchaseBacklogStatusHistory> PurchaseBacklogStatusHistories { get; } =
            new List<PurchaseBacklogStatusHistory>();
    }
}