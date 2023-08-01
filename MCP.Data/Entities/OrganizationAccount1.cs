namespace CED.Data.Entities
{
    public class OrganizationAccount1
    {
        public Guid OuaId { get; set; }

        public byte[] OuaTimeStamp { get; set; } = null!;

        public Guid OuaOrganizationUnitId { get; set; }

        public Guid OuaBankAccountId { get; set; }

        public string? OuaAccountCode { get; set; }

        public string? OuaAccountName { get; set; }

        public bool? OuaIsApproved { get; set; }

        public DateTime OuaCreatedDate { get; set; }

        public string? OuaCreatedBy { get; set; }

        public DateTime OuaLastModifiedDate { get; set; }

        public string? OuaLastModifiedBy { get; set; }
    }
}