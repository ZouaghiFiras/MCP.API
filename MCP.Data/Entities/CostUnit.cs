namespace CED.Data.Entities
{
    public class CostUnit
    {
        public Guid CunId { get; set; }

        public byte[] CunTimeStamp { get; set; } = null!;

        public string CunCode { get; set; } = null!;

        public string? CunShortName { get; set; }

        public string CunLongName { get; set; } = null!;

        public bool CunInactive { get; set; }

        public Guid CunLegalEntityId { get; set; }

        public Guid? CunLocalizableEntryId { get; set; }

        public DateTime CunCreatedDate { get; set; }

        public string? CunCreatedBy { get; set; }

        public DateTime CunLastModifiedDate { get; set; }

        public string? CunLastModifiedBy { get; set; }

        public virtual ICollection<BookingDimension> BookingDimensions { get; } = new List<BookingDimension>();

        public virtual LegalEntity CunLegalEntity { get; set; } = null!;

        public virtual LocalizableEntry? CunLocalizableEntry { get; set; }

        public virtual ICollection<Department> Departments { get; } = new List<Department>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<RecoveryStatement> RecoveryStatements { get; } = new List<RecoveryStatement>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();
    }
}