namespace CED.Data.Entities
{
    public class OrganizationAccount
    {
        public Guid OuaId { get; set; }

        public byte[] OuaTimeStamp { get; set; } = null!;

        public Guid OuaOrganizationUnitId { get; set; }

        public Guid OuaBankAccountId { get; set; }

        public string? OuaAccountCode { get; set; }

        public string? OuaAccountName { get; set; }

        public bool? OuaIsApproved { get; set; }

        public DateTime OuaCreatedDate { get; set; }

        public string? OuaCreatedBy { get; set; }

        public DateTime OuaLastModifiedDate { get; set; }

        public string? OuaLastModifiedBy { get; set; }

        public virtual LegalEntityAccount? LegalEntityAccount { get; set; }

        public virtual ICollection<OrganizationAccountAttachment> OrganizationAccountAttachments { get; } =
            new List<OrganizationAccountAttachment>();

        public virtual ICollection<OrganizationAccountValidation> OrganizationAccountValidations { get; } =
            new List<OrganizationAccountValidation>();

        public virtual BankAccount OuaBankAccount { get; set; } = null!;

        public virtual OrganizationUnit OuaOrganizationUnit { get; set; } = null!;

        public virtual ICollection<PaymentBatch> PaymentBatches { get; } = new List<PaymentBatch>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();
    }
}