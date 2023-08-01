namespace CED.Data.Entities
{
    public class PurchaseInvoiceApproval
    {
        public Guid PapId { get; set; }

        public byte[] PapTimeStamp { get; set; } = null!;

        public Guid PapPurchaseInvoiceAuthorizationId { get; set; }

        public DateTime PapApprovalDate { get; set; }

        public bool PapIsApproved { get; set; }

        public string? PapComment { get; set; }

        public Guid PapEmployeeId { get; set; }

        public string PapAutorizationRoleId { get; set; } = null!;

        public Guid? PapBankAccountId { get; set; }

        public decimal? PapCreditAmount { get; set; }

        public string? PapCurrencyCode { get; set; }

        public DateTime? PapExecutionDate { get; set; }

        public bool? PapUrgentTransfer { get; set; }

        public string? PapAccountNumber { get; set; }

        public string? PapAccountHolderName { get; set; }

        public string? PapAccountAddressLine1 { get; set; }

        public string? PapAccountAddressLine2 { get; set; }

        public string? PapCountryCode { get; set; }

        public string? PapBankName { get; set; }

        public Guid? PapBankId { get; set; }

        public string? PapIban { get; set; }

        public string? PapBic { get; set; }

        public string? PapRemittanceInformation { get; set; }

        public DateTime PapCreatedDate { get; set; }

        public string? PapCreatedBy { get; set; }

        public DateTime PapLastModifiedDate { get; set; }

        public string? PapLastModifiedBy { get; set; }

        public virtual AuthorizationRole PapAutorizationRole { get; set; } = null!;

        public virtual Bank? PapBank { get; set; }

        public virtual BankAccount? PapBankAccount { get; set; }

        public virtual Employee PapEmployee { get; set; } = null!;

        public virtual PurchaseInvoiceAuthorization PapPurchaseInvoiceAuthorization { get; set; } = null!;
    }
}