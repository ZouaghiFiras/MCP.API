namespace CED.Data.Entities
{
    public class Tenant1
    {
        public Guid TenId { get; set; }

        public byte[] TenTimeStamp { get; set; } = null!;

        public string TenCode { get; set; } = null!;

        public string TenName { get; set; } = null!;

        public bool TenInactive { get; set; }

        public DateTime TenCreatedDate { get; set; }

        public string? TenCreatedBy { get; set; }

        public DateTime TenLastModifiedDate { get; set; }

        public string? TenLastModifiedBy { get; set; }
    }
}