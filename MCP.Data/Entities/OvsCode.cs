namespace CED.Data.Entities
{
    public class OvsCode
    {
        public string OcoId { get; set; } = null!;

        public byte[] OcoTimeStamp { get; set; } = null!;

        public string? OcoShortName { get; set; }

        public string OcoLongName { get; set; } = null!;

        public bool OcoInactive { get; set; }

        public DateTime OcoCreatedDate { get; set; }

        public string? OcoCreatedBy { get; set; }

        public DateTime OcoLastModifiedDate { get; set; }

        public string? OcoLastModifiedBy { get; set; }

        public virtual ICollection<OvsMessageIncoming> OvsMessageIncomings { get; } = new List<OvsMessageIncoming>();

        public virtual ICollection<OvsMessageOutgoing> OvsMessageOutgoings { get; } = new List<OvsMessageOutgoing>();
    }
}