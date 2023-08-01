namespace CED.Data.Entities
{
    public class AssistancePlanClientsView
    {
        public Guid Id { get; set; }

        public string AssistancePlanNumber { get; set; } = null!;

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? ClientId { get; set; }

        public string? ClientCode { get; set; }

        public string ClientName { get; set; } = null!;

        public bool? Inactive { get; set; }

        public Guid? MandateId { get; set; }

        public string? MandateCode { get; set; }

        public string MandateName { get; set; } = null!;

        public Guid? InsurerId { get; set; }

        public string? InsurerCode { get; set; }

        public string InsurerName { get; set; } = null!;

        public Guid? InsurancePolicyId { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public string? InsuranceProductType { get; set; }

        public string? PolicyHolder { get; set; }

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public string? ChargedExpensesInvoiceRecipientCode { get; set; }

        public string ChargedExpensesInvoiceRecipientName { get; set; } = null!;

        public Guid? FeeInvoiceRecipientId { get; set; }

        public string? FeeInvoiceRecipientCode { get; set; }

        public string FeeInvoiceRecipientName { get; set; } = null!;

        public short? Priority { get; set; }

        public string? CoverageProductName { get; set; }

        public string? CoverageFreeField1 { get; set; }

        public string? CoverageFreeField2 { get; set; }

        public string? CoverageFreeField3 { get; set; }

        public string? CoverageFreeField4 { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}