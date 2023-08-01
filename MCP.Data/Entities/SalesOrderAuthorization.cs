namespace CED.Data.Entities
{
    public class SalesOrderAuthorization
    {
        public Guid SouId { get; set; }

        public byte[] SouTimeStamp { get; set; } = null!;

        public Guid SouSalesOrderId { get; set; }

        public string SouRequiredAutorizationRoleId { get; set; } = null!;

        public DateTime SouCreatedDate { get; set; }

        public string? SouCreatedBy { get; set; }

        public DateTime SouLastModifiedDate { get; set; }

        public string? SouLastModifiedBy { get; set; }

        public virtual ICollection<SalesOrderApproval> SalesOrderApprovals { get; } = new List<SalesOrderApproval>();

        public virtual AuthorizationRole SouRequiredAutorizationRole { get; set; } = null!;

        public virtual SalesOrder SouSalesOrder { get; set; } = null!;
    }
}