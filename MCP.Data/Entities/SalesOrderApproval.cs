namespace CED.Data.Entities
{
    public class SalesOrderApproval
    {
        public Guid SopId { get; set; }

        public byte[] SopTimeStamp { get; set; } = null!;

        public Guid SopSalesOrderAuthorizationId { get; set; }

        public DateTime SopApprovalDate { get; set; }

        public bool SopIsApproved { get; set; }

        public string? SopComment { get; set; }

        public Guid SopEmployeeId { get; set; }

        public string SopAutorizationRoleId { get; set; } = null!;

        public DateTime SopCreatedDate { get; set; }

        public string? SopCreatedBy { get; set; }

        public DateTime SopLastModifiedDate { get; set; }

        public string? SopLastModifiedBy { get; set; }

        public virtual AuthorizationRole SopAutorizationRole { get; set; } = null!;

        public virtual Employee SopEmployee { get; set; } = null!;

        public virtual SalesOrderAuthorization SopSalesOrderAuthorization { get; set; } = null!;
    }
}