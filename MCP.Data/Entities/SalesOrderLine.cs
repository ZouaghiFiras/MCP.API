namespace CED.Data.Entities
{
    public class SalesOrderLine
    {
        public Guid SolId { get; set; }

        public byte[] SolTimeStamp { get; set; } = null!;

        public Guid SolSalesOrderId { get; set; }

        public int SolLineNumber { get; set; }

        public string? SolDescription { get; set; }

        public string? SolYourReference { get; set; }

        public string? SolOurReference { get; set; }

        public DateTime? SolDeliveryDate { get; set; }

        public Guid? SolProductId { get; set; }

        public double SolQuantity { get; set; }

        public string? SolUnitOfMeasureId { get; set; }

        public decimal? SolUnitPrice { get; set; }

        public string? SolCurrencyCode { get; set; }

        public double? SolExchangeRate { get; set; }

        public Guid? SolExchangeRateId { get; set; }

        public decimal? SolDiscount { get; set; }

        public decimal SolGrossAmount { get; set; }

        public decimal? SolTaxBase { get; set; }

        public double SolTaxRate { get; set; }

        public string? SolTaxCode { get; set; }

        public decimal SolTaxAmount { get; set; }

        public bool SolTaxExempted { get; set; }

        public bool SolTaxReversedCharge { get; set; }

        public bool SolTaxImport { get; set; }

        public decimal SolNetAmount { get; set; }

        public bool SolIsTaxBeforeDiscount { get; set; }

        public string? SolLedgerAccount { get; set; }

        public Guid? SolCostCenterId { get; set; }

        public Guid? SolCostUnitId { get; set; }

        public bool SolIsCredit { get; set; }

        public string? SolDebitLineNumber { get; set; }

        public Guid? SolInvolvedPartyId { get; set; }

        public string? SolDossierNumber { get; set; }

        public Guid? SolDossierId { get; set; }

        public Guid? SolDossierAssignmentId { get; set; }

        public Guid? SolDossierPartyId { get; set; }

        public bool SolIsFee { get; set; }

        public decimal? SolFeeBase { get; set; }

        public decimal? SolFeeRate { get; set; }

        public decimal? SolMinimumFee { get; set; }

        public decimal? SolMaximumFee { get; set; }

        public decimal? SolFixedFee { get; set; }

        public decimal? SolHourlyFee { get; set; }

        public Guid? SolFeeAgreementId { get; set; }

        public decimal? SolAdditionalCharges { get; set; }

        public Guid? SolInvolvedCoverageId { get; set; }

        public bool SolIsVoided { get; set; }

        public string? SolJournalId { get; set; }

        public Guid? SolFeeSettlementLineId { get; set; }

        public Guid? SolDossierWorkActivityId { get; set; }

        public string? SolTaxCountryCode { get; set; }

        public decimal? SolForeignCurrencyAmount { get; set; }

        public string? SolForeignCurrencyCode { get; set; }

        public Guid? SolWorkingOrderId { get; set; }

        public DateTime SolCreatedDate { get; set; }

        public string? SolCreatedBy { get; set; }

        public DateTime SolLastModifiedDate { get; set; }

        public string? SolLastModifiedBy { get; set; }

        public Guid? SolWorkingOrderLineId { get; set; }

        public string? SolProductDescription { get; set; }

        public Guid? SolInvolvedObjectId { get; set; }

        public virtual ICollection<SalesInvoiceToOrderMapping> SalesInvoiceToOrderMappings { get; } =
            new List<SalesInvoiceToOrderMapping>();

        public virtual ICollection<SalesOrderCorrectionLine> SalesOrderCorrectionLines { get; } =
            new List<SalesOrderCorrectionLine>();

        public virtual ICollection<SalesOrderLineAttribute> SalesOrderLineAttributes { get; } =
            new List<SalesOrderLineAttribute>();

        public virtual ICollection<SalesOrderToAssistancePlanCoverageMapping>
            SalesOrderToAssistancePlanCoverageMappings { get; } = new List<SalesOrderToAssistancePlanCoverageMapping>();

        public virtual ICollection<SalesOrderToPurchaseMapping> SalesOrderToPurchaseMappings { get; } =
            new List<SalesOrderToPurchaseMapping>();

        public virtual ICollection<SalesOrderToTimeSheetMapping> SalesOrderToTimeSheetMappings { get; } =
            new List<SalesOrderToTimeSheetMapping>();

        public virtual ICollection<SalesOrderToWorkingOrderLineCoverageMapping>
            SalesOrderToWorkingOrderLineCoverageMappings { get; } =
            new List<SalesOrderToWorkingOrderLineCoverageMapping>();

        public virtual CostCenter? SolCostCenter { get; set; }

        public virtual CostUnit? SolCostUnit { get; set; }

        public virtual Dossier? SolDossier { get; set; }

        public virtual DossierAssignment? SolDossierAssignment { get; set; }

        public virtual DossierParty? SolDossierParty { get; set; }

        public virtual DossierWorkActivity? SolDossierWorkActivity { get; set; }

        public virtual ExchangeRate? SolExchangeRateNavigation { get; set; }

        public virtual FeeAgreement? SolFeeAgreement { get; set; }

        public virtual FeeSettlementLine? SolFeeSettlementLine { get; set; }

        public virtual InvolvedCoverage? SolInvolvedCoverage { get; set; }

        public virtual InvolvedObject? SolInvolvedObject { get; set; }

        public virtual Journal? SolJournal { get; set; }

        public virtual Product? SolProduct { get; set; }

        public virtual SalesOrder SolSalesOrder { get; set; } = null!;

        public virtual UnitOfMeasure? SolUnitOfMeasure { get; set; }

        public virtual WorkingOrder? SolWorkingOrder { get; set; }

        public virtual WorkingOrderLine? SolWorkingOrderLine { get; set; }
    }
}