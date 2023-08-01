namespace CED.Data.Entities
{
    public class CoverageMapping
    {
        public Guid CmId { get; set; }

        public string CmProspectCode { get; set; } = null!;

        public string CmEiscode { get; set; } = null!;

        public DateTime CmCreatedDate { get; set; }

        public string? CmCreatedBy { get; set; }

        public DateTime CmLastModifiedDate { get; set; }

        public string? CmLastModifiedBy { get; set; }

        public byte[] CmTimeStamp { get; set; } = null!;

        public bool CmDefaultEis { get; set; }

        public bool CmDefaultProspect { get; set; }
    }
}