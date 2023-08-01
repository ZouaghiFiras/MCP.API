namespace CED.Data.Entities
{
    public class ObjectMapping
    {
        public Guid OmId { get; set; }

        public string OmProspectCode { get; set; } = null!;

        public string OmEiscode { get; set; } = null!;

        public DateTime OmCreatedDate { get; set; }

        public string? OmCreatedBy { get; set; }

        public DateTime OmLastModifiedDate { get; set; }

        public string? OmLastModifiedBy { get; set; }

        public byte[] OmTimeStamp { get; set; } = null!;

        public bool OmDefaultEis { get; set; }

        public bool OmDefaultProspect { get; set; }
    }
}