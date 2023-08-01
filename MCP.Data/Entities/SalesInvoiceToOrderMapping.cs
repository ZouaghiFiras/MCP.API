namespace CED.Data.Entities
{
    public class SalesInvoiceToOrderMapping
    {
        public Guid SitoId { get; set; }

        public byte[] SitoTimeStamp { get; set; } = null!;

        public Guid SitoSalesInvoiceLineId { get; set; }

        public Guid SitoSalesOrderLineId { get; set; }

        public DateTime SitoCreatedDate { get; set; }

        public string? SitoCreatedBy { get; set; }

        public DateTime SitoLastModifiedDate { get; set; }

        public string? SitoLastModifiedBy { get; set; }

        public virtual SalesInvoiceLine SitoSalesInvoiceLine { get; set; } = null!;

        public virtual SalesOrderLine SitoSalesOrderLine { get; set; } = null!;
    }
}