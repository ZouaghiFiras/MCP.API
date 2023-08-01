namespace CED.Data.Entities
{
    public class EmployeeMapping
    {
        public Guid EmId { get; set; }

        public string EmProspectCode { get; set; } = null!;

        public string EmEiscode { get; set; } = null!;

        public DateTime EmCreatedDate { get; set; }

        public string? EmCreatedBy { get; set; }

        public DateTime EmLastModifiedDate { get; set; }

        public string? EmLastModifiedBy { get; set; }

        public byte[] EmTimeStamp { get; set; } = null!;
    }
}