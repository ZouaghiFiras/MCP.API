namespace CED.Data.Entities
{
    public class SalesOrderCorrectionApproval
    {
        public Guid SopcId { get; set; }

        public byte[] SopcTimeStamp { get; set; } = null!;

        public Guid SopcSalesOrderCorrectionAuthorizationId { get; set; }

        public DateTime SopcApprovalDate { get; set; }

        public bool SopcIsApproved { get; set; }

        public string? SopcComment { get; set; }

        public Guid SopcEmployeeId { get; set; }

        public string SopcAutorizationRoleId { get; set; } = null!;

        public DateTime SopcCreatedDate { get; set; }

        public string? SopcCreatedBy { get; set; }

        public DateTime SopcLastModifiedDate { get; set; }

        public string? SopcLastModifiedBy { get; set; }

        public virtual AuthorizationRole SopcAutorizationRole { get; set; } = null!;

        public virtual Employee SopcEmployee { get; set; } = null!;

        public virtual SalesOrderCorrectionAuthorization SopcSalesOrderCorrectionAuthorization { get; set; } = null!;
    }
}