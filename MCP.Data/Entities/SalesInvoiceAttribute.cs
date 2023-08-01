namespace CED.Data.Entities
{
    public class SalesInvoiceAttribute
    {
        public Guid IvaId { get; set; }

        public byte[] IvaTimeStamp { get; set; } = null!;

        public Guid IvaSalesInvoiceId { get; set; }

        public string IvaAttributeName { get; set; } = null!;

        public string IvaAttributeContent { get; set; } = null!;

        public DateTime IvaCreatedDate { get; set; }

        public string? IvaCreatedBy { get; set; }

        public DateTime IvaLastModifiedDate { get; set; }

        public string? IvaLastModifiedBy { get; set; }

        public virtual SalesInvoice IvaSalesInvoice { get; set; } = null!;
    }
}