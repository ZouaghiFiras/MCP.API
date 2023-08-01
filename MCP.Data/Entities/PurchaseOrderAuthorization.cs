namespace CED.Data.Entities
{
    public class PurchaseOrderAuthorization
    {
        public Guid PoaId { get; set; }

        public byte[] PoaTimeStamp { get; set; } = null!;

        public Guid PoaPurchaseOrderId { get; set; }

        public string PoaRequiredAutorizationRoleId { get; set; } = null!;

        public DateTime PoaCreatedDate { get; set; }

        public string? PoaCreatedBy { get; set; }

        public DateTime PoaLastModifiedDate { get; set; }

        public string? PoaLastModifiedBy { get; set; }

        public virtual PurchaseOrder PoaPurchaseOrder { get; set; } = null!;

        public virtual AuthorizationRole PoaRequiredAutorizationRole { get; set; } = null!;

        public virtual ICollection<PurchaseOrderApproval> PurchaseOrderApprovals { get; } =
            new List<PurchaseOrderApproval>();
    }
}