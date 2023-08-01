namespace CED.Data.Entities
{
    public class PurchaseInvoiceLine
    {
        public Guid PilId { get; set; }

        public byte[] PilTimeStamp { get; set; } = null!;

        public Guid PilPurchaseInvoiceId { get; set; }

        public int PilLineNumber { get; set; }

        public string? PilDescription { get; set; }

        public string? PilYourReference { get; set; }

        public DateTime? PilDeliveryDate { get; set; }

        public int? PilDeliveryWeek { get; set; }

        public string? PilProductCode { get; set; }

        public Guid? PilServiceId { get; set; }

        public double PilQuantity { get; set; }

        public string? PilUnitOfMeasureId { get; set; }

        public decimal? PilUnitPrice { get; set; }

        public decimal? PilDiscount { get; set; }

        public decimal PilGrossAmount { get; set; }

        public decimal? PilTaxBase { get; set; }

        public double PilTaxRate { get; set; }

        public string? PilTaxCode { get; set; }

        public decimal PilTaxAmount { get; set; }

        public decimal PilNetAmount { get; set; }

        public bool PilIsTaxBeforeDiscount { get; set; }

        public string? PilLedgerAccount { get; set; }

        public Guid? PilCostCenterId { get; set; }

        public Guid? PilCostUnitId { get; set; }

        public bool PilIsCredit { get; set; }

        public string? PilDebitLineNumber { get; set; }

        public string? PilOurReference { get; set; }

        public bool PilTaxExempted { get; set; }

        public bool PilTaxReversedCharge { get; set; }

        public bool PilTaxImport { get; set; }

        public string? PilDossierNumber { get; set; }

        public Guid? PilDossierId { get; set; }

        public Guid? PilDossierAssignmentId { get; set; }

        public Guid? PilDossierPartyId { get; set; }

        public string? PilJournalId { get; set; }

        public Guid? PilPurchaseLedgerSettingId { get; set; }

        public Guid? PilAssistancePlanId { get; set; }

        public string? PilTaxCountryCode { get; set; }

        public bool PilIsContinuousPost { get; set; }

        public DateTime PilCreatedDate { get; set; }

        public string? PilCreatedBy { get; set; }

        public DateTime PilLastModifiedDate { get; set; }

        public string? PilLastModifiedBy { get; set; }

        public string? PilDossierAssignmentNumber { get; set; }

        public Guid? PilWorkingOrderId { get; set; }

        public virtual ICollection<ClaimReservePayment> ClaimReservePayments { get; } = new List<ClaimReservePayment>();

        public virtual ICollection<CostOfSalesLine> CostOfSalesLines { get; } = new List<CostOfSalesLine>();

        public virtual AssistancePlan? PilAssistancePlan { get; set; }

        public virtual CostCenter? PilCostCenter { get; set; }

        public virtual CostUnit? PilCostUnit { get; set; }

        public virtual Dossier? PilDossier { get; set; }

        public virtual DossierAssignment? PilDossierAssignment { get; set; }

        public virtual DossierParty? PilDossierParty { get; set; }

        public virtual Journal? PilJournal { get; set; }

        public virtual PurchaseInvoice PilPurchaseInvoice { get; set; } = null!;

        public virtual PurchaseLedgerSetting? PilPurchaseLedgerSetting { get; set; }

        public virtual Service? PilService { get; set; }

        public virtual UnitOfMeasure? PilUnitOfMeasure { get; set; }

        public virtual WorkingOrder? PilWorkingOrder { get; set; }

        public virtual ICollection<PurchaseInvoiceAssistancePlan> PurchaseInvoiceAssistancePlans { get; } =
            new List<PurchaseInvoiceAssistancePlan>();

        public virtual ICollection<PurchaseInvoiceDossierAssignment> PurchaseInvoiceDossierAssignments { get; } =
            new List<PurchaseInvoiceDossierAssignment>();

        public virtual ICollection<PurchaseInvoiceLineAttribute> PurchaseInvoiceLineAttributes { get; } =
            new List<PurchaseInvoiceLineAttribute>();

        public virtual ICollection<PurchaseInvoiceToOrderMapping> PurchaseInvoiceToOrderMappings { get; } =
            new List<PurchaseInvoiceToOrderMapping>();

        public virtual ICollection<PurchaseInvoiceWorkingOrder> PurchaseInvoiceWorkingOrders { get; } =
            new List<PurchaseInvoiceWorkingOrder>();

        public virtual ICollection<PurchaseJournalEntryLine> PurchaseJournalEntryLines { get; } =
            new List<PurchaseJournalEntryLine>();

        public virtual ICollection<SalesInvoiceToPurchaseMapping> SalesInvoiceToPurchaseMappings { get; } =
            new List<SalesInvoiceToPurchaseMapping>();

        public virtual ICollection<SalesOrderToPurchaseMapping> SalesOrderToPurchaseMappings { get; } =
            new List<SalesOrderToPurchaseMapping>();
    }
}