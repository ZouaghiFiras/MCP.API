namespace CED.Data.Entities
{
    public class CostCenter
    {
        public Guid CcnId { get; set; }

        public byte[] CcnTimeStamp { get; set; } = null!;

        public string CcnCode { get; set; } = null!;

        public string? CcnShortName { get; set; }

        public string CcnLongName { get; set; } = null!;

        public bool CcnInactive { get; set; }

        public Guid CcnLegalEntityId { get; set; }

        public Guid? CcnLocalizableEntryId { get; set; }

        public DateTime CcnCreatedDate { get; set; }

        public string? CcnCreatedBy { get; set; }

        public DateTime CcnLastModifiedDate { get; set; }

        public string? CcnLastModifiedBy { get; set; }

        public virtual ICollection<BookingDimension> BookingDimensions { get; } = new List<BookingDimension>();

        public virtual ICollection<BusinessUnit> BusinessUnits { get; } = new List<BusinessUnit>();

        public virtual LegalEntity CcnLegalEntity { get; set; } = null!;

        public virtual LocalizableEntry? CcnLocalizableEntry { get; set; }

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<RecoveryStatement> RecoveryStatements { get; } = new List<RecoveryStatement>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();
    }
}