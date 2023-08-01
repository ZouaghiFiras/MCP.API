namespace CED.Data.Entities
{
    public class OrganizationCoverageProductsExtension
    {
        public Guid OcpeId { get; set; }

        public byte[] OcpeTimeStamp { get; set; } = null!;

        public bool OcpeMandateAdministrationChargedExpensesApplicable { get; set; }

        public bool OcpeMandateAdministrationFeeInvoicesApplicable { get; set; }

        public Guid OcpeFeeInvoiceRecipientId { get; set; }

        public Guid OcpeExternalCostInvoiceRecipientId { get; set; }

        public bool OcpeInactive { get; set; }

        public DateTime OcpeCreatedDate { get; set; }

        public string? OcpeCreatedBy { get; set; }

        public DateTime OcpeLastModifiedDate { get; set; }

        public string? OcpeLastModifiedBy { get; set; }

        public virtual OrganizationCoverageProduct Ocpe { get; set; } = null!;

        public virtual OrganizationUnit OcpeExternalCostInvoiceRecipient { get; set; } = null!;

        public virtual OrganizationUnit OcpeFeeInvoiceRecipient { get; set; } = null!;
    }
}