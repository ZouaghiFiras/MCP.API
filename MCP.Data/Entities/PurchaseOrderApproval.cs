namespace CED.Data.Entities
{
    public class PurchaseOrderApproval
    {
        public Guid PopId { get; set; }

        public byte[] PopTimeStamp { get; set; } = null!;

        public Guid PopPurchaseOrderAuthorizationId { get; set; }

        public DateTime PopApprovalDate { get; set; }

        public bool PopIsApproved { get; set; }

        public Guid PopEmployeeId { get; set; }

        public string PopAutorizationRoleId { get; set; } = null!;

        public DateTime PopCreatedDate { get; set; }

        public string? PopCreatedBy { get; set; }

        public DateTime PopLastModifiedDate { get; set; }

        public string? PopLastModifiedBy { get; set; }

        public virtual AuthorizationRole PopAutorizationRole { get; set; } = null!;

        public virtual Employee PopEmployee { get; set; } = null!;

        public virtual PurchaseOrderAuthorization PopPurchaseOrderAuthorization { get; set; } = null!;
    }
}