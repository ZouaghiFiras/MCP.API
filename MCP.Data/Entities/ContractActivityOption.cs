namespace CED.Data.Entities
{
    public class ContractActivityOption
    {
        public Guid CaoId { get; set; }

        public byte[] CaoTimeStamp { get; set; } = null!;

        public Guid CaoSubContractId { get; set; }

        public Guid CaoActivityOptionId { get; set; }

        public DateTime CaoCreatedDate { get; set; }

        public string? CaoCreatedBy { get; set; }

        public DateTime CaoLastModifiedDate { get; set; }

        public string? CaoLastModifiedBy { get; set; }

        public virtual ActivityOption CaoActivityOption { get; set; } = null!;

        public virtual SubContract CaoSubContract { get; set; } = null!;
    }
}