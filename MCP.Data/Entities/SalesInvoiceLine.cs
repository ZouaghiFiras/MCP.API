namespace CED.Data.Entities
{
    public class SalesInvoiceLine
    {
        public Guid IvlId { get; set; }

        public byte[] IvlTimeStamp { get; set; } = null!;

        public Guid IvlSalesInvoiceId { get; set; }

        public int IvlLineNumber { get; set; }

        public string? IvlDescription { get; set; }

        public string? IvlYourReference { get; set; }

        public DateTime? IvlDeliveryDate { get; set; }

        public int? IvlDeliveryWeek { get; set; }

        public string? IvlProductCode { get; set; }

        public Guid? IvlProductId { get; set; }

        public double IvlQuantity { get; set; }

        public string? IvlUnitOfMeasureId { get; set; }

        public decimal? IvlUnitPrice { get; set; }

        public decimal? IvlDiscount { get; set; }

        public decimal IvlGrossAmount { get; set; }

        public decimal? IvlTaxBase { get; set; }

        public double IvlTaxRate { get; set; }

        public string? IvlTaxCode { get; set; }

        public decimal IvlTaxAmount { get; set; }

        public decimal IvlNetAmount { get; set; }

        public bool IvlIsTaxBeforeDiscount { get; set; }

        public string? IvlLedgerAccount { get; set; }

        public Guid? IvlCostCenterId { get; set; }

        public Guid? IvlCostUnitId { get; set; }

        public bool IvlIsCredit { get; set; }

        public string? IvlDebitLineNumber { get; set; }

        public string? IvlOurReference { get; set; }

        public string? IvlPurchaseInvoiceNumber { get; set; }

        public bool IvlTaxExempted { get; set; }

        public bool IvlTaxReversedCharge { get; set; }

        public bool IvlTaxImport { get; set; }

        public string? IvlDossierNumber { get; set; }

        public Guid? IvlDossierId { get; set; }

        public Guid? IvlDossierAssignmentId { get; set; }

        public Guid? IvlDossierPartyId { get; set; }

        public bool IvlIsFee { get; set; }

        public decimal? IvlFeeBase { get; set; }

        public decimal? IvlFeeRate { get; set; }

        public decimal? IvlMinimumFee { get; set; }

        public decimal? IvlMaximumFee { get; set; }

        public decimal? IvlAdditionalCharges { get; set; }

        public string? IvlJournalId { get; set; }

        public Guid? IvlFeeSettlementLineId { get; set; }

        public Guid? IvlDossierWorkActivityId { get; set; }

        public Guid? IvlClientId { get; set; }

        public string? IvlTaxCountryCode { get; set; }

        public decimal? IvlForeignCurrencyAmount { get; set; }

        public string? IvlForeignCurrencyCode { get; set; }

        public Guid? IvlWorkingOrderId { get; set; }

        public DateTime IvlCreatedDate { get; set; }

        public string? IvlCreatedBy { get; set; }

        public DateTime IvlLastModifiedDate { get; set; }

        public string? IvlLastModifiedBy { get; set; }

        public virtual Client? IvlClient { get; set; }

        public virtual CostCenter? IvlCostCenter { get; set; }

        public virtual CostUnit? IvlCostUnit { get; set; }

        public virtual Dossier? IvlDossier { get; set; }

        public virtual DossierAssignment? IvlDossierAssignment { get; set; }

        public virtual DossierParty? IvlDossierParty { get; set; }

        public virtual DossierWorkActivity? IvlDossierWorkActivity { get; set; }

        public virtual FeeSettlementLine? IvlFeeSettlementLine { get; set; }

        public virtual Journal? IvlJournal { get; set; }

        public virtual Product? IvlProduct { get; set; }

        public virtual SalesInvoice IvlSalesInvoice { get; set; } = null!;

        public virtual UnitOfMeasure? IvlUnitOfMeasure { get; set; }

        public virtual WorkingOrder? IvlWorkingOrder { get; set; }

        public virtual ICollection<SalesInvoiceLineAttribute> SalesInvoiceLineAttributes { get; } =
            new List<SalesInvoiceLineAttribute>();

        public virtual ICollection<SalesInvoiceToOrderMapping> SalesInvoiceToOrderMappings { get; } =
            new List<SalesInvoiceToOrderMapping>();

        public virtual ICollection<SalesInvoiceToPurchaseMapping> SalesInvoiceToPurchaseMappings { get; } =
            new List<SalesInvoiceToPurchaseMapping>();

        public virtual ICollection<SalesJournalEntryLine> SalesJournalEntryLines { get; } =
            new List<SalesJournalEntryLine>();
    }
}