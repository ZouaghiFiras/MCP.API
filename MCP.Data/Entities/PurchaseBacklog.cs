namespace CED.Data.Entities
{
    public class PurchaseBacklog
    {
        public Guid PbgId { get; set; }

        public byte[] PbgTimeStamp { get; set; } = null!;

        public string PbgBacklogsNumber { get; set; } = null!;

        public DateTime PbgBacklogsDate { get; set; }

        public decimal? PbgGrossAmount { get; set; }

        public decimal? PbgTaxAmount { get; set; }

        public decimal? PbgTaxExemptedAmount { get; set; }

        public decimal? PbgTaxResversedChargeAmount { get; set; }

        public decimal? PbgTaxImportAmount { get; set; }

        public decimal? PbgNetAmount { get; set; }

        public decimal? PbgBlockedAmount { get; set; }

        public DateTime? PbgDueDate { get; set; }

        public string? PbgCurrencyCode { get; set; }

        public Guid? PbgLegalEntityId { get; set; }

        public Guid? PbgSupplierId { get; set; }

        public string? PbgSupplierInvoiceNumber { get; set; }

        public DateTime? PbgSupplierInvoiceDate { get; set; }

        public Guid? PbgPaymentConditionId { get; set; }

        public Guid? PbgPaymentMethodId { get; set; }

        public bool? PbgIsCredit { get; set; }

        public Guid? PbgTenantId { get; set; }

        public string? PbgCultureCode { get; set; }

        public Guid? PbgEmployeeId { get; set; }

        public string? PbgDossierNumber { get; set; }

        public Guid? PbgDossierId { get; set; }

        public string? PbgDossierAssignmentNumber { get; set; }

        public Guid? PbgDossierAssignmentId { get; set; }

        public string? PbgAssistancePlanNumber { get; set; }

        public Guid? PbgAssitancePlanId { get; set; }

        public bool? PbgIsIntercompany { get; set; }

        public bool? PbgIsRecipientLegalEntity { get; set; }

        public string? PbgRecipientName { get; set; }

        public string? PbgPayeeName { get; set; }

        public Guid? PbgPayeeAddressId { get; set; }

        public Guid? PbgPayeeBankAccountId { get; set; }

        public bool? PbgIsInvoice { get; set; }

        public string? PbgPaymentReference { get; set; }

        public string? PbgSourceTypeId { get; set; }

        public string? PbgSourceFrom { get; set; }

        public string? PbgSourceTo { get; set; }

        public string? PbgSourceSubject { get; set; }

        public DateTime? PbgSourceReceivedDate { get; set; }

        public string? PbgJsonEntryForm { get; set; }

        public string? PbgInUseBy { get; set; }

        public short? PbgInvoicePriorityTypeId { get; set; }

        public DateTime? PbgInvestigationDueDate { get; set; }

        public DateTime PbgCreatedDate { get; set; }

        public string? PbgCreatedBy { get; set; }

        public DateTime PbgLastModifiedDate { get; set; }

        public string? PbgLastModifiedBy { get; set; }

        public decimal? PbgDiscount { get; set; }

        public string? PbgEntryNumber { get; set; }

        public string? PbgEntrySystem { get; set; }

        public bool? PbgIsIncorrectInvoiceFollowedUp { get; set; }

        public Guid? PbgCurrentStatusHistoryId { get; set; }

        public DateTime? PbgCurrentStatusHistoryStartDate { get; set; }

        public string? PbgCurrentStatusCode { get; set; }

        public string? PbgTaxCountryCode { get; set; }

        public string? PbgWorkingOrderNumber { get; set; }

        public Guid? PbgWorkingOrderId { get; set; }

        public Guid? PbgBlockedBankAccountId { get; set; }

        public virtual AssistancePlan? PbgAssitancePlan { get; set; }

        public virtual BankAccount? PbgBlockedBankAccount { get; set; }

        public virtual Dossier? PbgDossier { get; set; }

        public virtual DossierAssignment? PbgDossierAssignment { get; set; }

        public virtual Employee? PbgEmployee { get; set; }

        public virtual InvoicePriorityType? PbgInvoicePriorityType { get; set; }

        public virtual LegalEntity? PbgLegalEntity { get; set; }

        public virtual Address? PbgPayeeAddress { get; set; }

        public virtual BankAccount? PbgPayeeBankAccount { get; set; }

        public virtual PaymentCondition? PbgPaymentCondition { get; set; }

        public virtual PaymentMethod? PbgPaymentMethod { get; set; }

        public virtual PurchaseBacklogSourceType? PbgSourceType { get; set; }

        public virtual Supplier? PbgSupplier { get; set; }

        public virtual Tenant? PbgTenant { get; set; }

        public virtual WorkingOrder? PbgWorkingOrder { get; set; }

        public virtual ICollection<PurchaseBacklogAssistancePlan> PurchaseBacklogAssistancePlans { get; } =
            new List<PurchaseBacklogAssistancePlan>();

        public virtual ICollection<PurchaseBacklogAttachment> PurchaseBacklogAttachments { get; } =
            new List<PurchaseBacklogAttachment>();

        public virtual ICollection<PurchaseBacklogLine> PurchaseBacklogLines { get; } = new List<PurchaseBacklogLine>();

        public virtual ICollection<PurchaseBacklogNote> PurchaseBacklogNotes { get; } = new List<PurchaseBacklogNote>();

        public virtual ICollection<PurchaseBacklogStatusHistory> PurchaseBacklogStatusHistories { get; } =
            new List<PurchaseBacklogStatusHistory>();

        public virtual ICollection<PurchaseBacklogValidation> PurchaseBacklogValidations { get; } =
            new List<PurchaseBacklogValidation>();

        public virtual ICollection<PurchaseBacklogWorkingOrderLineCost> PurchaseBacklogWorkingOrderLineCosts { get; } =
            new List<PurchaseBacklogWorkingOrderLineCost>();

        public virtual ICollection<PurchaseBacklogWorkingOrder> PurchaseBacklogWorkingOrders { get; } =
            new List<PurchaseBacklogWorkingOrder>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();
    }
}