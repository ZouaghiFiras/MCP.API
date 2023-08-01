namespace CED.Data.Entities
{
    public class ProductMapping
    {
        public Guid PmId { get; set; }

        public string PmProspectCode { get; set; } = null!;

        public string PmEiscode { get; set; } = null!;

        public DateTime PmCreatedDate { get; set; }

        public string? PmCreatedBy { get; set; }

        public DateTime PmLastModifiedDate { get; set; }

        public string? PmLastModifiedBy { get; set; }

        public byte[] PmTimeStamp { get; set; } = null!;

        public bool PmDefaultEis { get; set; }

        public bool PmDefaultProspect { get; set; }
    }
}