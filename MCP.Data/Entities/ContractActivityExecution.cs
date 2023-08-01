namespace CED.Data.Entities
{
    public class ContractActivityExecution
    {
        public Guid CaeId { get; set; }

        public byte[] CaeTimeStamp { get; set; } = null!;

        public Guid CaeSubContractId { get; set; }

        public Guid CaeActivityExecutionId { get; set; }

        public DateTime CaeCreatedDate { get; set; }

        public string? CaeCreatedBy { get; set; }

        public DateTime CaeLastModifiedDate { get; set; }

        public string? CaeLastModifiedBy { get; set; }

        public virtual ActivityExecution CaeActivityExecution { get; set; } = null!;

        public virtual SubContract CaeSubContract { get; set; } = null!;
    }
}