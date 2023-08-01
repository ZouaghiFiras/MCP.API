namespace CED.Data.Entities
{
    public class OvsLiabilityPercentage
    {
        public string OlpId { get; set; } = null!;

        public byte[] OlpTimeStamp { get; set; } = null!;

        public string? OlpShortName { get; set; }

        public string OlpLongName { get; set; } = null!;

        public double OlpPercentage { get; set; }

        public bool OlpInactive { get; set; }

        public DateTime OlpCreatedDate { get; set; }

        public string? OlpCreatedBy { get; set; }

        public DateTime OlpLastModifiedDate { get; set; }

        public string? OlpLastModifiedBy { get; set; }

        public virtual ICollection<OvsMessageIncoming> OvsMessageIncomings { get; } = new List<OvsMessageIncoming>();

        public virtual ICollection<OvsMessageOutgoing> OvsMessageOutgoings { get; } = new List<OvsMessageOutgoing>();
    }
}