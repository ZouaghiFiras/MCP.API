namespace CED.Data.Entities
{
    public class SalesJournalEntryLine
    {
        public Guid SjlId { get; set; }

        public byte[] SjlTimeStamp { get; set; } = null!;

        public Guid SjlSalesInvoiceLineId { get; set; }

        public Guid SjlJournalEntryLineId { get; set; }

        public DateTime SjlCreatedDate { get; set; }

        public string? SjlCreatedBy { get; set; }

        public DateTime SjlLastModifiedDate { get; set; }

        public string? SjlLastModifiedBy { get; set; }

        public virtual JournalEntryLine SjlJournalEntryLine { get; set; } = null!;

        public virtual SalesInvoiceLine SjlSalesInvoiceLine { get; set; } = null!;
    }
}