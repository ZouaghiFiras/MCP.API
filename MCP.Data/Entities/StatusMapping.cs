namespace CED.Data.Entities
{
    public class StatusMapping
    {
        public Guid SmId { get; set; }

        public string SmProspectCode { get; set; } = null!;

        public string SmEiscode { get; set; } = null!;

        public DateTime SmCreatedDate { get; set; }

        public string? SmCreatedBy { get; set; }

        public DateTime SmLastModifiedDate { get; set; }

        public string? SmLastModifiedBy { get; set; }

        public byte[] SmTimeStamp { get; set; } = null!;

        public bool SmDefaultEis { get; set; }

        public bool SmDefaultProspect { get; set; }
    }
}