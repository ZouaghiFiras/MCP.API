namespace CED.Data.Entities
{
    public class InvoiceType
    {
        public Guid IvtId { get; set; }

        public byte[] IvtTimeStamp { get; set; } = null!;

        public string IvtCode { get; set; } = null!;

        public string? IvtShortName { get; set; }

        public string IvtLongName { get; set; } = null!;

        public bool IvtInactive { get; set; }

        public Guid IvtLegalEntityId { get; set; }

        public Guid? IvtLocalizableEntryId { get; set; }

        public DateTime IvtCreatedDate { get; set; }

        public string? IvtCreatedBy { get; set; }

        public DateTime IvtLastModifiedDate { get; set; }

        public string? IvtLastModifiedBy { get; set; }

        public virtual LegalEntity IvtLegalEntity { get; set; } = null!;

        public virtual LocalizableEntry? IvtLocalizableEntry { get; set; }

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();
    }
}