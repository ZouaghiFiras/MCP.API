namespace CED.Data.Entities
{
    public class DepartmentMapping
    {
        public Guid DmId { get; set; }

        public string DmProspectCode { get; set; } = null!;

        public string DmEiscode { get; set; } = null!;

        public DateTime DmCreatedDate { get; set; }

        public string? DmCreatedBy { get; set; }

        public DateTime DmLastModifiedDate { get; set; }

        public string? DmLastModifiedBy { get; set; }

        public byte[] DmTimeStamp { get; set; } = null!;
    }
}