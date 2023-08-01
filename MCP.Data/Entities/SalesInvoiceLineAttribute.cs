namespace CED.Data.Entities
{
    public class SalesInvoiceLineAttribute
    {
        public Guid IlaId { get; set; }

        public byte[] IlaTimeStamp { get; set; } = null!;

        public Guid IlaSalesInvoiceLineId { get; set; }

        public string IlaAttributeName { get; set; } = null!;

        public string IlaAttributeContent { get; set; } = null!;

        public DateTime IlaCreatedDate { get; set; }

        public string? IlaCreatedBy { get; set; }

        public DateTime IlaLastModifiedDate { get; set; }

        public string? IlaLastModifiedBy { get; set; }

        public virtual SalesInvoiceLine IlaSalesInvoiceLine { get; set; } = null!;
    }
}