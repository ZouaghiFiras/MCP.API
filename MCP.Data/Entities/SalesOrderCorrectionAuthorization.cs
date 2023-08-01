namespace CED.Data.Entities
{
    public class SalesOrderCorrectionAuthorization
    {
        public Guid SoucId { get; set; }

        public byte[] SoucTimeStamp { get; set; } = null!;

        public Guid SoucSalesOrderCorrectionId { get; set; }

        public Guid SoucEmployeeId { get; set; }

        public string SoucRequiredAutorizationRoleId { get; set; } = null!;

        public DateTime SoucCreatedDate { get; set; }

        public string? SoucCreatedBy { get; set; }

        public DateTime SoucLastModifiedDate { get; set; }

        public string? SoucLastModifiedBy { get; set; }

        public virtual ICollection<SalesOrderCorrectionApproval> SalesOrderCorrectionApprovals { get; } =
            new List<SalesOrderCorrectionApproval>();

        public virtual Employee SoucEmployee { get; set; } = null!;

        public virtual AuthorizationRole SoucRequiredAutorizationRole { get; set; } = null!;

        public virtual SalesOrderCorrection SoucSalesOrderCorrection { get; set; } = null!;
    }
}