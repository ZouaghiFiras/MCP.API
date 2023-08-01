namespace CED.Data.Entities
{
    public class PurchaseBacklogsIncorrectView
    {
        public Guid Id { get; set; }

        public string BacklogsNumber { get; set; } = null!;

        public string? AssistancePlanNumber { get; set; }

        public string? AssistancePlanNumbers { get; set; }

        public string? AssistancePlanIds { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public string? WorkingOrderNumber { get; set; }

        public string? WorkingOrderNumbers { get; set; }

        public string? WorkingOrderIds { get; set; }

        public Guid? WorkingOrderId { get; set; }

        public DateTime BacklogsDate { get; set; }

        public int? Priority { get; set; }

        public decimal? BlockedAmount { get; set; }

        public string? CultureCode { get; set; }

        public string? CurrencyCode { get; set; }

        public decimal? GrossAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? TaxExemptedAmount { get; set; }

        public decimal? TaxImportAmount { get; set; }

        public decimal? TaxReversedChargeAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public DateTime? DueDate { get; set; }

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public Guid? SupplierId { get; set; }

        public string? SupplierCode { get; set; }

        public string SupplierName { get; set; } = null!;

        public DateTime? SupplierInvoiceDate { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public string? SupplierIban { get; set; }

        public string? SupplierAccountNumber { get; set; }

        public Guid? PaymentConditionId { get; set; }

        public string? PaymentConditionCode { get; set; }

        public string? PaymentConditionName { get; set; }

        public Guid? PaymentMethodId { get; set; }

        public string? PaymentMethodCode { get; set; }

        public string? PaymentMethodName { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? EmployeeName { get; set; }

        public Guid? TenantId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public bool? IsIntercompany { get; set; }

        public Guid? ClientId { get; set; }

        public string ClientName { get; set; } = null!;

        public bool? IsRecipientLegalEntity { get; set; }

        public string? RecipientName { get; set; }

        public string? PayeeName { get; set; }

        public string? PayeeStreetName { get; set; }

        public string? PayeeHouseNo { get; set; }

        public string? PayeeHouseNoAddition { get; set; }

        public string? PayeePostalCode { get; set; }

        public string? PayeeCity { get; set; }

        public string? PayeeProvince { get; set; }

        public string? PayeeCountryCode { get; set; }

        public string? PayeeAccountHolderName { get; set; }

        public string? PayeeAccountNumber { get; set; }

        public string? PayeeBankName { get; set; }

        public string? PayeeIban { get; set; }

        public string? PayeeBic { get; set; }

        public Guid? PayeeBankAccountId { get; set; }

        public bool? IsInvoice { get; set; }

        public bool? IsCredit { get; set; }

        public string? PaymentReference { get; set; }

        public string? JsonEntryForm { get; set; }

        public string? PurchaseBacklogStatusCode { get; set; }

        public string? PurchaseBacklogStatusName { get; set; }

        public DateTime? PurchaseBacklogStatusCreatedDate { get; set; }

        public string? SourceFrom { get; set; }

        public string? SourceTo { get; set; }

        public DateTime? SourceReceivedDate { get; set; }

        public string? SourceSubject { get; set; }

        public string? SourceTypeId { get; set; }

        public string? InUseBy { get; set; }

        public string? DossierTypeCode { get; set; }

        public string? DossierTypeName { get; set; }

        public bool IsMedicalDossier { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public bool IsIncorrectInvoiceFollowedUp { get; set; }
    }
}