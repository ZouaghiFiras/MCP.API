namespace CED.Data.Entities
{
    public class OvsMessageStatus
    {
        public Guid OmsId { get; set; }

        public byte[] OmsTimeStamp { get; set; } = null!;

        public string OmsCode { get; set; } = null!;

        public string? OmsShortName { get; set; }

        public string OmsLongName { get; set; } = null!;

        public bool OmsInactive { get; set; }

        public DateTime OmsCreatedDate { get; set; }

        public string? OmsCreatedBy { get; set; }

        public DateTime OmsLastModifiedDate { get; set; }

        public string? OmsLastModifiedBy { get; set; }

        public virtual ICollection<OvsMessageIncoming> OvsMessageIncomings { get; } = new List<OvsMessageIncoming>();

        public virtual ICollection<OvsMessageOutgoing> OvsMessageOutgoings { get; } = new List<OvsMessageOutgoing>();
    }
}