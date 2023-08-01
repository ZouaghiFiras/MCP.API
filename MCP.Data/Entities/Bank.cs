namespace CED.Data.Entities
{
    public class Bank
    {
        public Guid BnId { get; set; }

        public byte[] BnTimeStamp { get; set; } = null!;

        public string? BnSettlingNumber { get; set; }

        public string? BnSwift { get; set; }

        public bool BnIsIbanConsistent { get; set; }

        public string? BnCultureCodePreferredLanguage { get; set; }

        public bool? BnInactive { get; set; }

        public DateTime BnCreatedDate { get; set; }

        public string? BnCreatedBy { get; set; }

        public DateTime BnLastModifiedDate { get; set; }

        public string? BnLastModifiedBy { get; set; }

        public virtual ICollection<BankAccount> BankAccounts { get; } = new List<BankAccount>();

        public virtual OrganizationUnit Bn { get; set; } = null!;

        public virtual ICollection<CreditTransfer> CreditTransfers { get; } = new List<CreditTransfer>();

        public virtual ICollection<PurchaseInvoiceApproval> PurchaseInvoiceApprovals { get; } =
            new List<PurchaseInvoiceApproval>();
    }
}