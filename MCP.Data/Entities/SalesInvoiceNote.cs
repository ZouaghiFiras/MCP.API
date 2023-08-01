namespace CED.Data.Entities
{
    public class SalesInvoiceNote
    {
        public Guid SinId { get; set; }

        public byte[] SinTimeStamp { get; set; } = null!;

        public Guid SinSalesInvoiceId { get; set; }

        public string SinNotes { get; set; } = null!;

        public DateTime SinCreatedDate { get; set; }

        public string? SinCreatedBy { get; set; }

        public DateTime SinLastModifiedDate { get; set; }

        public string? SinLastModifiedBy { get; set; }

        public virtual SalesInvoice SinSalesInvoice { get; set; } = null!;
    }
}