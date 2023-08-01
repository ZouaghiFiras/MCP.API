namespace CED.Data.Entities
{
    public class InsurancePolicyClientsView
    {
        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public Guid InsurancePolicyId { get; set; }

        public string InsurancePolicyNumber { get; set; } = null!;

        public string? InsurancePolicyFreeField1 { get; set; }

        public string? InsurancePolicyFreeField2 { get; set; }

        public string? InsurancePolicyFreeField3 { get; set; }

        public string? InsurancePolicyFreeField4 { get; set; }

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}