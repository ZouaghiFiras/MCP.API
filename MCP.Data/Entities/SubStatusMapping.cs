namespace CED.Data.Entities
{
    public class SubStatusMapping
    {
        public Guid SsmId { get; set; }

        public string SsmProspectStatusCode { get; set; } = null!;

        public string SsmProspectSubStatusCode { get; set; } = null!;

        public string SsmEiscode { get; set; } = null!;

        public DateTime SsmCreatedDate { get; set; }

        public string? SsmCreatedBy { get; set; }

        public DateTime SsmLastModifiedDate { get; set; }

        public string? SsmLastModifiedBy { get; set; }

        public byte[] SsmTimeStamp { get; set; } = null!;

        public bool SsmDefaultEis { get; set; }

        public bool SsmDefaultProspect { get; set; }
    }
}