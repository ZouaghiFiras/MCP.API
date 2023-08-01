namespace CED.Data.Entities
{
    public class PurchaseBacklogSourceType
    {
        public string PbtId { get; set; } = null!;

        public byte[] PbtTimeStamp { get; set; } = null!;

        public string PbtDescription { get; set; } = null!;

        public bool PbtInactive { get; set; }

        public Guid? PbtLocalizableEntryId { get; set; }

        public DateTime PbtCreatedDate { get; set; }

        public string? PbtCreatedBy { get; set; }

        public DateTime PbtLastModifiedDate { get; set; }

        public string? PbtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? PbtLocalizableEntry { get; set; }

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();
    }
}