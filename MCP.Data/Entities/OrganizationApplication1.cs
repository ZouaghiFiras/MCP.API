namespace CED.Data.Entities
{
    public class OrganizationApplication1
    {
        public Guid OraId { get; set; }

        public byte[] OraTimeStamp { get; set; } = null!;

        public Guid OraOrganizationId { get; set; }

        public Guid OraApplicationId { get; set; }

        public bool OraInactive { get; set; }

        public DateTime OraCreatedDate { get; set; }

        public string? OraCreatedBy { get; set; }

        public DateTime OraLastModifiedDate { get; set; }

        public string? OraLastModifiedBy { get; set; }
    }
}