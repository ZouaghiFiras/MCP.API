namespace CED.Data.Entities
{
    public class PurchaseInvoiceAuthorization
    {
        public Guid PiaId { get; set; }

        public byte[] PiaTimeStamp { get; set; } = null!;

        public Guid PiaPurchaseInvoiceId { get; set; }

        public string PiaRequiredAutorizationRoleId { get; set; } = null!;

        public DateTime PiaCreatedDate { get; set; }

        public string? PiaCreatedBy { get; set; }

        public DateTime PiaLastModifiedDate { get; set; }

        public string? PiaLastModifiedBy { get; set; }

        public virtual PurchaseInvoice PiaPurchaseInvoice { get; set; } = null!;

        public virtual AuthorizationRole PiaRequiredAutorizationRole { get; set; } = null!;

        public virtual ICollection<PurchaseInvoiceApproval> PurchaseInvoiceApprovals { get; } =
            new List<PurchaseInvoiceApproval>();
    }
}