namespace CED.Data.Entities
{
    public class OrganizationNote1
    {
        public Guid OnoId { get; set; }

        public byte[] OnoTimeStamp { get; set; } = null!;

        public Guid OnoOrganizationUnitId { get; set; }

        public string? OnoNotes { get; set; }

        public DateTime OnoCreatedDate { get; set; }

        public string? OnoCreatedBy { get; set; }

        public DateTime OnoLastModifiedDate { get; set; }

        public string? OnoLastModifiedBy { get; set; }
    }
}