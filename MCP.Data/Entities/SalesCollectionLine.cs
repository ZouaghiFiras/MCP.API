namespace CED.Data.Entities
{
    public class SalesCollectionLine
    {
        public Guid SclId { get; set; }

        public byte[] SclTimeStamp { get; set; } = null!;

        public Guid SclSalesCollectionId { get; set; }

        public Guid SclSalesCollectionDebtorId { get; set; }

        public int SclLineNumber { get; set; }

        public Guid SclSalesInvoiceId { get; set; }

        public bool SclIsRemoved { get; set; }

        public DateTime? SclRemovalDate { get; set; }

        public DateTime SclCreatedDate { get; set; }

        public string? SclCreatedBy { get; set; }

        public DateTime SclLastModifiedDate { get; set; }

        public string? SclLastModifiedBy { get; set; }

        public virtual SalesCollection SclSalesCollection { get; set; } = null!;

        public virtual SalesCollectionDebtor SclSalesCollectionDebtor { get; set; } = null!;

        public virtual SalesInvoice SclSalesInvoice { get; set; } = null!;
    }
}