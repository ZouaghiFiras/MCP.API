namespace CED.Data.Entities
{
    public class ContractWorkActivity
    {
        public Guid CwaId { get; set; }

        public byte[] CwaTimeStamp { get; set; } = null!;

        public Guid CwaSubContractId { get; set; }

        public Guid CwaWorkActivityId { get; set; }

        public DateTime CwaCreatedDate { get; set; }

        public string? CwaCreatedBy { get; set; }

        public DateTime CwaLastModifiedDate { get; set; }

        public string? CwaLastModifiedBy { get; set; }

        public virtual SubContract CwaSubContract { get; set; } = null!;

        public virtual WorkActivity CwaWorkActivity { get; set; } = null!;
    }
}