namespace CED.Data.Entities
{
    public class MainContract
    {
        public Guid MncId { get; set; }

        public byte[] MncTimeStamp { get; set; } = null!;

        public string? MncContractNumber { get; set; }

        public DateTime MncContractDate { get; set; }

        public DateTime? MncTerminationDate { get; set; }

        public Guid MncClientId { get; set; }

        public DateTime MncCreatedDate { get; set; }

        public string? MncCreatedBy { get; set; }

        public DateTime MncLastModifiedDate { get; set; }

        public string? MncLastModifiedBy { get; set; }

        public virtual Client MncClient { get; set; } = null!;

        public virtual ICollection<SubContract> SubContracts { get; } = new List<SubContract>();
    }
}