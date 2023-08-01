namespace CED.Data.Entities
{
    public class BlacklistSource
    {
        public Guid BlsId { get; set; }

        public byte[] BlsTimeStamp { get; set; } = null!;

        public short BlsCode { get; set; }

        public string BlsName { get; set; } = null!;

        public string BlsResource { get; set; } = null!;

        public DateTime BlsCreatedDate { get; set; }

        public string? BlsCreatedBy { get; set; }

        public DateTime BlsLastModifiedDate { get; set; }

        public string? BlsLastModifiedBy { get; set; }

        public virtual ICollection<BlacklistCheckResult> BlacklistCheckResults { get; } =
            new List<BlacklistCheckResult>();
    }
}