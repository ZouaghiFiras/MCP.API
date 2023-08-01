namespace CED.Data.Entities
{
    public class OvsMessageType
    {
        public string OmtId { get; set; } = null!;

        public byte[] OmtTimeStamp { get; set; } = null!;

        public string? OmtShortName { get; set; }

        public string OmtLongName { get; set; } = null!;

        public bool OmtInactive { get; set; }

        public DateTime OmtCreatedDate { get; set; }

        public string? OmtCreatedBy { get; set; }

        public DateTime OmtLastModifiedDate { get; set; }

        public string? OmtLastModifiedBy { get; set; }

        public virtual ICollection<OvsMessageIncoming> OvsMessageIncomings { get; } = new List<OvsMessageIncoming>();

        public virtual ICollection<OvsMessageOutgoing> OvsMessageOutgoings { get; } = new List<OvsMessageOutgoing>();
    }
}