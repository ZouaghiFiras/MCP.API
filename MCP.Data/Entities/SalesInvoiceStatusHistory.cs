namespace CED.Data.Entities
{
    public class SalesInvoiceStatusHistory
    {
        public Guid SishId { get; set; }

        public byte[] SishTimeStamp { get; set; } = null!;

        public Guid SishSalesInvoiceId { get; set; }

        public Guid SishSalesInvoiceStatusId { get; set; }

        public DateTime SishStartDate { get; set; }

        public string? SishStatusChangeReason { get; set; }

        public DateTime SishCreatedDate { get; set; }

        public string? SishCreatedBy { get; set; }

        public DateTime SishLastModifiedDate { get; set; }

        public string? SishLastModifiedBy { get; set; }

        public virtual SalesInvoice SishSalesInvoice { get; set; } = null!;

        public virtual SalesInvoiceStatus SishSalesInvoiceStatus { get; set; } = null!;
    }
}