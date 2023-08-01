namespace CED.Data.Entities
{
    public class ContractInsuranceObject
    {
        public Guid CioId { get; set; }

        public byte[] CioTimeStamp { get; set; } = null!;

        public Guid CioSubContractId { get; set; }

        public Guid CioInsuranceObjectId { get; set; }

        public DateTime CioCreatedDate { get; set; }

        public string? CioCreatedBy { get; set; }

        public DateTime CioLastModifiedDate { get; set; }

        public string? CioLastModifiedBy { get; set; }

        public virtual InsuranceObject CioInsuranceObject { get; set; } = null!;

        public virtual SubContract CioSubContract { get; set; } = null!;
    }
}