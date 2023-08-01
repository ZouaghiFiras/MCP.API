namespace CED.Data.Entities
{
    public class PurchaseInvoiceStatus
    {
        public Guid PisId { get; set; }

        public byte[] PisTimeStamp { get; set; } = null!;

        public string PisCode { get; set; } = null!;

        public string? PisShortName { get; set; }

        public string PisLongName { get; set; } = null!;

        public bool PisInactive { get; set; }

        public Guid? PisLocalizableEntryId { get; set; }

        public DateTime PisCreatedDate { get; set; }

        public string? PisCreatedBy { get; set; }

        public DateTime PisLastModifiedDate { get; set; }

        public string? PisLastModifiedBy { get; set; }

        public virtual LocalizableEntry? PisLocalizableEntry { get; set; }

        public virtual ICollection<PurchaseInvoiceStatusHistory> PurchaseInvoiceStatusHistories { get; } =
            new List<PurchaseInvoiceStatusHistory>();
    }
}