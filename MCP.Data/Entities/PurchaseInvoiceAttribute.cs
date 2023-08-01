namespace CED.Data.Entities
{
    public class PurchaseInvoiceAttribute
    {
        public Guid PvaId { get; set; }

        public byte[] PvaTimeStamp { get; set; } = null!;

        public Guid PvaPurchaseInvoiceId { get; set; }

        public string PvaAttributeName { get; set; } = null!;

        public string PvaAttributeContent { get; set; } = null!;

        public DateTime PvaCreatedDate { get; set; }

        public string? PvaCreatedBy { get; set; }

        public DateTime PvaLastModifiedDate { get; set; }

        public string? PvaLastModifiedBy { get; set; }

        public virtual PurchaseInvoice PvaPurchaseInvoice { get; set; } = null!;
    }
}