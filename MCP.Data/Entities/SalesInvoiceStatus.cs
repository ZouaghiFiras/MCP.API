namespace CED.Data.Entities
{
    public class SalesInvoiceStatus
    {
        public Guid SisId { get; set; }

        public byte[] SisTimeStamp { get; set; } = null!;

        public string SisCode { get; set; } = null!;

        public string? SisShortName { get; set; }

        public string SisLongName { get; set; } = null!;

        public bool SisInactive { get; set; }

        public Guid? SisLocalizableEntryId { get; set; }

        public DateTime SisCreatedDate { get; set; }

        public string? SisCreatedBy { get; set; }

        public DateTime SisLastModifiedDate { get; set; }

        public string? SisLastModifiedBy { get; set; }

        public virtual ICollection<SalesInvoiceStatusHistory> SalesInvoiceStatusHistories { get; } =
            new List<SalesInvoiceStatusHistory>();

        public virtual LocalizableEntry? SisLocalizableEntry { get; set; }
    }
}