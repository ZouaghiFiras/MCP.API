namespace CED.Data.Entities
{
    public class Creditor
    {
        public Guid CdId { get; set; }

        public byte[] CdTimeStamp { get; set; } = null!;

        public string CdNumber { get; set; } = null!;

        public string CdName { get; set; } = null!;

        public string? CdName2 { get; set; }

        public string? CdName3 { get; set; }

        public string? CdSearchText { get; set; }

        public bool CdIsCompany { get; set; }

        public short? CdGenderId { get; set; }

        public string? CdPhone { get; set; }

        public string? CdPhoneExt { get; set; }

        public string? CdFax { get; set; }

        public string? CdEmail { get; set; }

        public string? CdHomePage { get; set; }

        public Guid? CdAddressId { get; set; }

        public Guid? CdPostOfficeBoxId { get; set; }

        public Guid CdLegalEntityId { get; set; }

        public string? CdLedgerAccount { get; set; }

        public string? CdEntrySystem { get; set; }

        public string? CdEntryNumber { get; set; }

        public string? CdEntryBatch { get; set; }

        public string? CdVatNumber { get; set; }

        public bool CdNoVatNumber { get; set; }

        public string? CdChamberOfCommerceNumber { get; set; }

        public Guid? CdBankAccountId { get; set; }

        public Guid? CdBlockedAccountId { get; set; }

        public string? CdExactPaymentMethod { get; set; }

        public bool CdInactive { get; set; }

        public Guid? CdTenantId { get; set; }

        public string? CdPurchaseTaxCodeId { get; set; }

        public DateTime? CdExactExportDate { get; set; }

        public Guid? CdDefaultSupplierId { get; set; }

        public string? CdContactPersonName { get; set; }

        public string? CdContactPersonPhone { get; set; }

        public string? CdContactPersonEmail { get; set; }

        public DateTime CdCreatedDate { get; set; }

        public string? CdCreatedBy { get; set; }

        public DateTime CdLastModifiedDate { get; set; }

        public string? CdLastModifiedBy { get; set; }

        public Guid? CdExactAccountCategoryId { get; set; }

        public virtual Address? CdAddress { get; set; }

        public virtual BankAccount? CdBankAccount { get; set; }

        public virtual BankAccount? CdBlockedAccount { get; set; }

        public virtual Supplier? CdDefaultSupplier { get; set; }

        public virtual ExactAccountCategory? CdExactAccountCategory { get; set; }

        public virtual Gender? CdGender { get; set; }

        public virtual LegalEntity CdLegalEntity { get; set; } = null!;

        public virtual PostOfficeBox? CdPostOfficeBox { get; set; }

        public virtual Tenant? CdTenant { get; set; }

        public virtual ICollection<CreditorAccount> CreditorAccounts { get; } = new List<CreditorAccount>();

        public virtual ICollection<CreditorAttribute> CreditorAttributes { get; } = new List<CreditorAttribute>();

        public virtual ICollection<CreditorOrganizationRelation> CreditorOrganizationRelations { get; } =
            new List<CreditorOrganizationRelation>();

        public virtual ICollection<CreditorStatusHistory> CreditorStatusHistories { get; } =
            new List<CreditorStatusHistory>();

        public virtual ICollection<CreditorTemplate> CreditorTemplates { get; } = new List<CreditorTemplate>();

        public virtual ICollection<GeneralCreditor> GeneralCreditors { get; } = new List<GeneralCreditor>();

        public virtual ICollection<JournalEntryLine> JournalEntryLines { get; } = new List<JournalEntryLine>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();
    }
}