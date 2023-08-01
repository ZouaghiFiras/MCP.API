namespace CED.Data.Entities
{
    public class ContractInsuranceCoverage
    {
        public Guid CcoId { get; set; }

        public byte[] CcoTimeStamp { get; set; } = null!;

        public Guid CcoSubContractId { get; set; }

        public Guid CcoInsuranceCoverageId { get; set; }

        public DateTime CcoCreatedDate { get; set; }

        public string? CcoCreatedBy { get; set; }

        public DateTime CcoLastModifiedDate { get; set; }

        public string? CcoLastModifiedBy { get; set; }

        public virtual InsuranceCoverage CcoInsuranceCoverage { get; set; } = null!;

        public virtual SubContract CcoSubContract { get; set; } = null!;
    }
}