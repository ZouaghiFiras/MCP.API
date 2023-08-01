namespace CED.Data.Entities
{
    public class DeedOfAssignmentMapping
    {
        public Guid DofmId { get; set; }

        public string DofmProspectCode { get; set; } = null!;

        public string DofmEiscode { get; set; } = null!;

        public DateTime DofmCreatedDate { get; set; }

        public string? DofmCreatedBy { get; set; }

        public DateTime DofmLastModifiedDate { get; set; }

        public string? DofmLastModifiedBy { get; set; }

        public byte[] DofmTimeStamp { get; set; } = null!;
    }
}