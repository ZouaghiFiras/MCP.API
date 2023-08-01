namespace CED.Data.Entities
{
    public class OvsDeregistrationReason
    {
        public string OdrId { get; set; } = null!;

        public byte[] OdrTimeStamp { get; set; } = null!;

        public string? OdrShortName { get; set; }

        public string OdrLongName { get; set; } = null!;

        public bool OdrInactive { get; set; }

        public DateTime OdrCreatedDate { get; set; }

        public string? OdrCreatedBy { get; set; }

        public DateTime OdrLastModifiedDate { get; set; }

        public string? OdrLastModifiedBy { get; set; }

        public virtual ICollection<OvsMessageIncoming> OvsMessageIncomings { get; } = new List<OvsMessageIncoming>();
    }
}