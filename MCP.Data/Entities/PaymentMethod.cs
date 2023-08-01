namespace CED.Data.Entities
{
    public class PaymentMethod
    {
        public Guid PmtId { get; set; }

        public byte[] PmtTimeStamp { get; set; } = null!;

        public string PmtCode { get; set; } = null!;

        public string? PmtShortName { get; set; }

        public string PmtLongName { get; set; } = null!;

        public bool PmtIsCreditorDefault { get; set; }

        public bool PmtIsDebtorDefault { get; set; }

        public bool PmtInactive { get; set; }

        public Guid? PmtLocalizableEntryId { get; set; }

        public DateTime PmtCreatedDate { get; set; }

        public string? PmtCreatedBy { get; set; }

        public DateTime PmtLastModifiedDate { get; set; }

        public string? PmtLastModifiedBy { get; set; }

        public virtual ICollection<LegalEntityPaymentMethod> LegalEntityPaymentMethods { get; } =
            new List<LegalEntityPaymentMethod>();

        public virtual ICollection<OrganizationPaymentMethod> OrganizationPaymentMethods { get; } =
            new List<OrganizationPaymentMethod>();

        public virtual LocalizableEntry? PmtLocalizableEntry { get; set; }

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();
    }
}