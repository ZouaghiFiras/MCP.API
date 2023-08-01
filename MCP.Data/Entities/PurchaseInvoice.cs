namespace CED.Data.Entities
{
    public class PurchaseInvoice
    {
        public Guid PivId { get; set; }

        public byte[] PivTimeStamp { get; set; } = null!;

        public string PivNumber { get; set; } = null!;

        public DateTime PivInvoiceDate { get; set; }

        public string? PivEntryNumber { get; set; }

        public string? PivEntrySystem { get; set; }

        public string? PivEntryBatch { get; set; }

        public string? PivDescription { get; set; }

        public string? PivYourReference { get; set; }

        public string? PivOurReference { get; set; }

        public decimal PivGrossAmount { get; set; }

        public decimal PivTaxAmount { get; set; }

        public decimal PivTaxExemptedAmount { get; set; }

        public decimal PivTaxResversedChargeAmount { get; set; }

        public decimal PivTaxImportAmount { get; set; }

        public decimal PivNetAmount { get; set; }

        public decimal? PivOpenAmount { get; set; }

        public DateTime? PivDueDate { get; set; }

        public string? PivCurrencyCode { get; set; }

        public double? PivExchangeRate { get; set; }

        public bool PivIsPrinted { get; set; }

        public bool PivIsImported { get; set; }

        public Guid PivLegalEntityId { get; set; }

        public Guid? PivOrganizationUnitId { get; set; }

        public Guid PivInvoiceTypeId { get; set; }

        public Guid PivCreditorId { get; set; }

        public Guid? PivPaymentConditionId { get; set; }

        public Guid? PivPaymentMethodId { get; set; }

        public bool PivIsCredit { get; set; }

        public string? PivCreditReason { get; set; }

        public string? PivDebitEntryNumber { get; set; }

        public Guid? PivDebitPurchaseInvoiceId { get; set; }

        public decimal PivBlockedAmount { get; set; }

        public Guid? PivTenantId { get; set; }

        public string? PivCultureCode { get; set; }

        public Guid? PivEmployeeId { get; set; }

        public string? PivJournalId { get; set; }

        public string? PivBookingNumber { get; set; }

        public DateTime? PivBookingDate { get; set; }

        public string? PivSupplierInvoiceNumber { get; set; }

        public DateTime? PivSupplierInvoiceDate { get; set; }

        public Guid? PivSupplierId { get; set; }

        public Guid? PivCostCenterId { get; set; }

        public Guid? PivCostUnitId { get; set; }

        public string? PivDossierNumber { get; set; }

        public Guid? PivDossierId { get; set; }

        public Guid? PivDossierAssignmentId { get; set; }

        public Guid? PivDossierPartyId { get; set; }

        public bool PivIsIntercompany { get; set; }

        public bool PivPayorIsDossierParty { get; set; }

        public bool PivIsRecipientLegalEntity { get; set; }

        public string? PivRecipientName { get; set; }

        public string? PivPayeeName { get; set; }

        public Guid? PivPayeeAddressId { get; set; }

        public Guid? PivPayeeBankAccountId { get; set; }

        public bool? PivIsInvoice { get; set; }

        public string? PivJsonEntryForm { get; set; }

        public string? PivPaymentReference { get; set; }

        public string? PivLeadCurrencyCode { get; set; }

        public Guid? PivExchangeRateId { get; set; }

        public Guid? PivAssistancePlanId { get; set; }

        public Guid? PivPurchaseBacklogId { get; set; }

        public string? PivPaymentCurrencyCode { get; set; }

        public Guid? PivPaymentExchangeRateId { get; set; }

        public double? PivPaymentExchangeRate { get; set; }

        public Guid? PivForeignToPaymentExchangeRateId { get; set; }

        public double? PivForeignToPaymentExchangeRate { get; set; }

        public short? PivInvoicePriorityTypeId { get; set; }

        public Guid? PivFinancialBookingPeriodId { get; set; }

        public bool PivIsMarkedForReallocation { get; set; }

        public DateTime PivCreatedDate { get; set; }

        public string? PivCreatedBy { get; set; }

        public DateTime PivLastModifiedDate { get; set; }

        public string? PivLastModifiedBy { get; set; }

        public Guid? PivCurrentStatusHistoryId { get; set; }

        public DateTime? PivCurrentStatusHistoryStartDate { get; set; }

        public string? PivCurrentStatusCode { get; set; }

        public string? PivTaxCountryCode { get; set; }

        public Guid? PivPaymentToLeadExchangeRateId { get; set; }

        public double? PivPaymentToLeadExchangeRate { get; set; }

        public string? PivDossierAssignmentNumber { get; set; }

        public Guid? PivBlockedBankAccountId { get; set; }

        public Guid? PivWorkingOrderId { get; set; }

        public virtual ICollection<BankStatementReconcilliation> BankStatementReconcilliations { get; } =
            new List<BankStatementReconcilliation>();

        public virtual ICollection<ClaimReserveLine> ClaimReserveLines { get; } = new List<ClaimReserveLine>();

        public virtual ICollection<CreditTransferJournalEntryLine> CreditTransferJournalEntryLines { get; } =
            new List<CreditTransferJournalEntryLine>();

        public virtual ICollection<CreditTransferPurchaseInvoice> CreditTransferPurchaseInvoices { get; } =
            new List<CreditTransferPurchaseInvoice>();

        public virtual ICollection<PurchaseInvoice> InversePivDebitPurchaseInvoice { get; } =
            new List<PurchaseInvoice>();

        public virtual AssistancePlan? PivAssistancePlan { get; set; }

        public virtual BankAccount? PivBlockedBankAccount { get; set; }

        public virtual CostCenter? PivCostCenter { get; set; }

        public virtual CostUnit? PivCostUnit { get; set; }

        public virtual Creditor PivCreditor { get; set; } = null!;

        public virtual PurchaseInvoice? PivDebitPurchaseInvoice { get; set; }

        public virtual Dossier? PivDossier { get; set; }

        public virtual DossierAssignment? PivDossierAssignment { get; set; }

        public virtual DossierParty? PivDossierParty { get; set; }

        public virtual Employee? PivEmployee { get; set; }

        public virtual ExchangeRate? PivExchangeRateNavigation { get; set; }

        public virtual FinancialBookingPeriod? PivFinancialBookingPeriod { get; set; }

        public virtual ExchangeRate? PivForeignToPaymentExchangeRateNavigation { get; set; }

        public virtual InvoicePriorityType? PivInvoicePriorityType { get; set; }

        public virtual InvoiceType PivInvoiceType { get; set; } = null!;

        public virtual Journal? PivJournal { get; set; }

        public virtual LegalEntity PivLegalEntity { get; set; } = null!;

        public virtual OrganizationUnit? PivOrganizationUnit { get; set; }

        public virtual Address? PivPayeeAddress { get; set; }

        public virtual BankAccount? PivPayeeBankAccount { get; set; }

        public virtual PaymentCondition? PivPaymentCondition { get; set; }

        public virtual ExchangeRate? PivPaymentExchangeRateNavigation { get; set; }

        public virtual PaymentMethod? PivPaymentMethod { get; set; }

        public virtual ExchangeRate? PivPaymentToLeadExchangeRateNavigation { get; set; }

        public virtual PurchaseBacklog? PivPurchaseBacklog { get; set; }

        public virtual Supplier? PivSupplier { get; set; }

        public virtual Tenant? PivTenant { get; set; }

        public virtual WorkingOrder? PivWorkingOrder { get; set; }

        public virtual ICollection<PurchaseInvoiceAttachment> PurchaseInvoiceAttachments { get; } =
            new List<PurchaseInvoiceAttachment>();

        public virtual ICollection<PurchaseInvoiceAttribute> PurchaseInvoiceAttributes { get; } =
            new List<PurchaseInvoiceAttribute>();

        public virtual ICollection<PurchaseInvoiceAuthorization> PurchaseInvoiceAuthorizations { get; } =
            new List<PurchaseInvoiceAuthorization>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseInvoiceNote> PurchaseInvoiceNotes { get; } = new List<PurchaseInvoiceNote>();

        public virtual ICollection<PurchaseInvoiceStatusHistory> PurchaseInvoiceStatusHistories { get; } =
            new List<PurchaseInvoiceStatusHistory>();

        public virtual ICollection<PurchasePaymentBatchLine> PurchasePaymentBatchLines { get; } =
            new List<PurchasePaymentBatchLine>();

        public virtual ICollection<PurchasePayment> PurchasePayments { get; } = new List<PurchasePayment>();
    }
}