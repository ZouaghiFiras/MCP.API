namespace CED.Data.Entities
{
    public class BankAccount
    {
        public Guid BacId { get; set; }

        public byte[] BacTimeStamp { get; set; } = null!;

        public string BacAccountNumber { get; set; } = null!;

        public string? BacAccountAbbreviation { get; set; }

        public string BacAccountName { get; set; } = null!;

        public string? BacAccountAddressLine1 { get; set; }

        public string? BacAccountAddressLine2 { get; set; }

        public string? BacBankName { get; set; }

        public Guid? BacBankId { get; set; }

        public string? BacIban { get; set; }

        public string? BacBic { get; set; }

        public string BacCurrencyCode { get; set; } = null!;

        public string BacCountryCode { get; set; } = null!;

        public string? BacAccountIdentifier { get; set; }

        public bool BacIsSepaAccount { get; set; }

        public bool BacIsBlockedAccount { get; set; }

        public bool BacIsValidated { get; set; }

        public bool BacInactive { get; set; }

        public DateTime BacCreatedDate { get; set; }

        public string? BacCreatedBy { get; set; }

        public DateTime BacLastModifiedDate { get; set; }

        public string? BacLastModifiedBy { get; set; }

        public double BacLaborCostPercentage { get; set; }

        public virtual Bank? BacBank { get; set; }

        public virtual ICollection<BankAccountAttachment> BankAccountAttachments { get; } =
            new List<BankAccountAttachment>();

        public virtual ICollection<BankAccountValidation> BankAccountValidations { get; } =
            new List<BankAccountValidation>();

        public virtual ICollection<BankStatement> BankStatements { get; } = new List<BankStatement>();

        public virtual ICollection<CreditTransfer> CreditTransfers { get; } = new List<CreditTransfer>();

        public virtual ICollection<CreditorAccount> CreditorAccounts { get; } = new List<CreditorAccount>();

        public virtual ICollection<Creditor> CreditorCdBankAccounts { get; } = new List<Creditor>();

        public virtual ICollection<Creditor> CreditorCdBlockedAccounts { get; } = new List<Creditor>();

        public virtual ICollection<DebtorAccount> DebtorAccounts { get; } = new List<DebtorAccount>();

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();

        public virtual ICollection<Journal> Journals { get; } = new List<Journal>();

        public virtual ICollection<LegalEntity> LegalEntities { get; } = new List<LegalEntity>();

        public virtual ICollection<OrganizationAccount> OrganizationAccounts { get; } = new List<OrganizationAccount>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogPbgBlockedBankAccounts { get; } =
            new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogPbgPayeeBankAccounts { get; } =
            new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoiceApproval> PurchaseInvoiceApprovals { get; } =
            new List<PurchaseInvoiceApproval>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoicePivBlockedBankAccounts { get; } =
            new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoicePivPayeeBankAccounts { get; } =
            new List<PurchaseInvoice>();

        public virtual ICollection<ReconcilliationRefundAccount>
            ReconcilliationRefundAccountRraReconcilliationBankAccounts { get; } =
            new List<ReconcilliationRefundAccount>();

        public virtual ICollection<ReconcilliationRefundAccount> ReconcilliationRefundAccountRraRefundBankAccounts
        {
            get;
        } = new List<ReconcilliationRefundAccount>();
    }
}