namespace CED.Data.Entities
{
    public class InsurancePoliciesView
    {
        public Guid Id { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public Guid? ClientId { get; set; }

        public string? ClientCode { get; set; }

        public string ClientName { get; set; } = null!;

        public Guid? MandateId { get; set; }

        public string? MandateCode { get; set; }

        public string MandateName { get; set; } = null!;

        public Guid? InsurerId { get; set; }

        public string? InsurerCode { get; set; }

        public string InsurerName { get; set; } = null!;

        public Guid? InsurancePolicyId { get; set; }

        public string InsurancePolicyNumber { get; set; } = null!;

        public Guid? DossierId { get; set; }

        public string? PolicyHolder { get; set; }

        public string ContractNumber { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public Guid? FeeInvoiceRecipientId { get; set; }

        public Guid? PurchaseInvoiceId { get; set; }

        public string? FreeField1 { get; set; }

        public string? FreeField2 { get; set; }

        public string? FreeField3 { get; set; }

        public string? FreeField4 { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}