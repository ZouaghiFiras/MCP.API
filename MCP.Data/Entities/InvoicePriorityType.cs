namespace CED.Data.Entities
{
    public class InvoicePriorityType
    {
        public short IvptId { get; set; }

        public byte[] IvptTimeStamp { get; set; } = null!;

        public string IvptCode { get; set; } = null!;

        public string IvptDescription { get; set; } = null!;

        public short IvptRank { get; set; }

        public bool IvptInactive { get; set; }

        public Guid? IvptLocalizableEntryId { get; set; }

        public DateTime IvptCreatedDate { get; set; }

        public string? IvptCreatedBy { get; set; }

        public DateTime IvptLastModifiedDate { get; set; }

        public string? IvptLastModifiedBy { get; set; }

        public virtual LocalizableEntry? IvptLocalizableEntry { get; set; }

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();
    }
}