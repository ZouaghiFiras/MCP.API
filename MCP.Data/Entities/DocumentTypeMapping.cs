namespace CED.Data.Entities
{
    public class DocumentTypeMapping
    {
        public Guid DtmId { get; set; }

        public string DtmProspectCode { get; set; } = null!;

        public string DtmEiscode { get; set; } = null!;

        public DateTime DtmCreatedDate { get; set; }

        public string? DtmCreatedBy { get; set; }

        public DateTime DtmLastModifiedDate { get; set; }

        public string? DtmLastModifiedBy { get; set; }

        public byte[] DtmTimeStamp { get; set; } = null!;
    }
}