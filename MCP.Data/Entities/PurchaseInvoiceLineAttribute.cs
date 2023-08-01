namespace CED.Data.Entities
{
    public class PurchaseInvoiceLineAttribute
    {
        public Guid PlaId { get; set; }

        public byte[] PlaTimeStamp { get; set; } = null!;

        public Guid PlaPurchaseInvoiceLineId { get; set; }

        public string PlaAttributeName { get; set; } = null!;

        public string PlaAttributeContent { get; set; } = null!;

        public DateTime PlaCreatedDate { get; set; }

        public string? PlaCreatedBy { get; set; }

        public DateTime PlaLastModifiedDate { get; set; }

        public string? PlaLastModifiedBy { get; set; }

        public virtual PurchaseInvoiceLine PlaPurchaseInvoiceLine { get; set; } = null!;
    }
}