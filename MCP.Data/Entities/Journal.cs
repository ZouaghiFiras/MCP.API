namespace CED.Data.Entities
{
    public class Journal
    {
        public string JrlId { get; set; } = null!;

        public byte[] JrlTimeStamp { get; set; } = null!;

        public string? JrlAbbreviation { get; set; }

        public string JrlDescription { get; set; } = null!;

        public string JrlCurrencyCode { get; set; } = null!;

        public string JrlJournalTypeId { get; set; } = null!;

        public string JrlGeneralLedgerId { get; set; } = null!;

        public Guid? JrlBankAccountId { get; set; }

        public Guid JrlLegalEntityId { get; set; }

        public string? JrlExactAdministration { get; set; }

        public string? JrlExactJournal { get; set; }

        public bool JrlInactive { get; set; }

        public Guid? JrlLocalizableEntryId { get; set; }

        public DateTime JrlCreatedDate { get; set; }

        public string? JrlCreatedBy { get; set; }

        public DateTime JrlLastModifiedDate { get; set; }

        public string? JrlLastModifiedBy { get; set; }

        public virtual ICollection<CostOfSale> CostOfSales { get; } = new List<CostOfSale>();

        public virtual ICollection<JournalEntry> JournalEntries { get; } = new List<JournalEntry>();

        public virtual ICollection<JournalSetting> JournalSettings { get; } = new List<JournalSetting>();

        public virtual BankAccount? JrlBankAccount { get; set; }

        public virtual GeneralLedger JrlGeneralLedger { get; set; } = null!;

        public virtual JournalType JrlJournalType { get; set; } = null!;

        public virtual LegalEntity JrlLegalEntity { get; set; } = null!;

        public virtual LocalizableEntry? JrlLocalizableEntry { get; set; }

        public virtual ICollection<LedgerSetting> LedgerSettings { get; } = new List<LedgerSetting>();

        public virtual ICollection<LegalEntity> LegalEntityLeCreditPurchaseJournals { get; } = new List<LegalEntity>();

        public virtual ICollection<LegalEntity> LegalEntityLeCreditSalesJournals { get; } = new List<LegalEntity>();

        public virtual ICollection<LegalEntity> LegalEntityLePurchaseJournals { get; } = new List<LegalEntity>();

        public virtual ICollection<LegalEntity> LegalEntityLeSalesJournals { get; } = new List<LegalEntity>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseLedgerSetting> PurchaseLedgerSettings { get; } =
            new List<PurchaseLedgerSetting>();

        public virtual ICollection<ReconcilliationAction> ReconcilliationActions { get; } =
            new List<ReconcilliationAction>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesLedgerSetting> SalesLedgerSettings { get; } = new List<SalesLedgerSetting>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();
    }
}