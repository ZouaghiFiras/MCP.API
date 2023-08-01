namespace CED.Data.Entities
{
    public class SalesInvoice
    {
        public Guid InvId { get; set; }

        public byte[] InvTimeStamp { get; set; } = null!;

        public string InvNumber { get; set; } = null!;

        public DateTime InvInvoiceDate { get; set; }

        public string? InvEntryNumber { get; set; }

        public string? InvEntrySystem { get; set; }

        public string? InvEntryBatch { get; set; }

        public string? InvDescription { get; set; }

        public string? InvYourReference { get; set; }

        public string? InvOurReference { get; set; }

        public decimal InvGrossAmount { get; set; }

        public decimal InvTaxAmount { get; set; }

        public decimal InvNetAmount { get; set; }

        public decimal? InvOpenAmount { get; set; }

        public DateTime? InvDueDate { get; set; }

        public string? InvCurrencyCode { get; set; }

        public double? InvExchangeRate { get; set; }

        public bool InvIsPrinted { get; set; }

        public bool InvIsFiscalised { get; set; }

        public bool InvIsImported { get; set; }

        public Guid InvLegalEntityId { get; set; }

        public Guid? InvOrganizationUnitId { get; set; }

        public Guid InvInvoiceTypeId { get; set; }

        public Guid InvDebtorId { get; set; }

        public Guid? InvPaymentConditionId { get; set; }

        public bool InvIsCredit { get; set; }

        public string? InvDebitEntryNumber { get; set; }

        public Guid? InvDebitSalesInvoiceId { get; set; }

        public Guid? InvTenantId { get; set; }

        public decimal InvTaxExemptedAmount { get; set; }

        public decimal InvTaxReversedChargeAmount { get; set; }

        public decimal InvDiscount { get; set; }

        public decimal InvTaxImportAmount { get; set; }

        public string? InvCultureCode { get; set; }

        public Guid? InvEmployeeId { get; set; }

        public string? InvJournalId { get; set; }

        public string? InvBookingNumber { get; set; }

        public DateTime? InvBookingDate { get; set; }

        public Guid? InvCostCenterId { get; set; }

        public Guid? InvCostUnitId { get; set; }

        public string? InvDossierNumber { get; set; }

        public Guid? InvDossierId { get; set; }

        public Guid? InvDossierAssignmentId { get; set; }

        public Guid? InvDossierPartyId { get; set; }

        public bool InvIsIntercompany { get; set; }

        public string? InvPaymentReference { get; set; }

        public string? InvLeadCurrencyCode { get; set; }

        public Guid? InvExchangeRateId { get; set; }

        public string? InvInvoiceDeliveryMethodId { get; set; }

        public decimal? InvBlockedAmount { get; set; }

        public Guid? InvBlockedOrganizationAccountId { get; set; }

        public Guid? InvFinancialBookingPeriodId { get; set; }

        public bool InvIsCollectable { get; set; }

        public DateTime? InvCollectableDate { get; set; }

        public DateTime InvCreatedDate { get; set; }

        public string? InvCreatedBy { get; set; }

        public DateTime InvLastModifiedDate { get; set; }

        public string? InvLastModifiedBy { get; set; }

        public Guid? InvCurrentStatusHistoryId { get; set; }

        public DateTime? InvCurrentStatusHistoryStartDate { get; set; }

        public string? InvCurrentStatusCode { get; set; }

        public string? InvTaxCountryCode { get; set; }

        public Guid? InvParentId { get; set; }

        public decimal? InvOwnRiskAmount { get; set; }

        public decimal? InvVatDeductableAmount { get; set; }

        public virtual ICollection<BankStatementReconcilliation> BankStatementReconcilliations { get; } =
            new List<BankStatementReconcilliation>();

        public virtual ICollection<CreditTransferJournalEntryLine> CreditTransferJournalEntryLines { get; } =
            new List<CreditTransferJournalEntryLine>();

        public virtual ICollection<CreditTransferSalesInvoice> CreditTransferSalesInvoices { get; } =
            new List<CreditTransferSalesInvoice>();

        public virtual OrganizationAccount? InvBlockedOrganizationAccount { get; set; }

        public virtual CostCenter? InvCostCenter { get; set; }

        public virtual CostUnit? InvCostUnit { get; set; }

        public virtual SalesInvoice? InvDebitSalesInvoice { get; set; }

        public virtual Debtor InvDebtor { get; set; } = null!;

        public virtual Dossier? InvDossier { get; set; }

        public virtual DossierAssignment? InvDossierAssignment { get; set; }

        public virtual DossierParty? InvDossierParty { get; set; }

        public virtual Employee? InvEmployee { get; set; }

        public virtual ExchangeRate? InvExchangeRateNavigation { get; set; }

        public virtual FinancialBookingPeriod? InvFinancialBookingPeriod { get; set; }

        public virtual InvoiceDeliveryMethod? InvInvoiceDeliveryMethod { get; set; }

        public virtual InvoiceType InvInvoiceType { get; set; } = null!;

        public virtual Journal? InvJournal { get; set; }

        public virtual LegalEntity InvLegalEntity { get; set; } = null!;

        public virtual OrganizationUnit? InvOrganizationUnit { get; set; }

        public virtual SalesInvoice? InvParent { get; set; }

        public virtual PaymentCondition? InvPaymentCondition { get; set; }

        public virtual Tenant? InvTenant { get; set; }

        public virtual ICollection<SalesInvoice> InverseInvDebitSalesInvoice { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesInvoice> InverseInvParent { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesCollectionLine> SalesCollectionLines { get; } = new List<SalesCollectionLine>();

        public virtual ICollection<SalesInvoiceAttachment> SalesInvoiceAttachments { get; } =
            new List<SalesInvoiceAttachment>();

        public virtual ICollection<SalesInvoiceAttribute> SalesInvoiceAttributes { get; } =
            new List<SalesInvoiceAttribute>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesInvoiceNote> SalesInvoiceNotes { get; } = new List<SalesInvoiceNote>();

        public virtual ICollection<SalesInvoiceStatusHistory> SalesInvoiceStatusHistories { get; } =
            new List<SalesInvoiceStatusHistory>();

        public virtual ICollection<SalesPayment> SalesPayments { get; } = new List<SalesPayment>();
    }
}