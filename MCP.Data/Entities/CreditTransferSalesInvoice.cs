namespace CED.Data.Entities
{
    public class CreditTransferSalesInvoice
    {
        public Guid CtsId { get; set; }

        public byte[] CtsTimeStamp { get; set; } = null!;

        public Guid CtsCreditTransferId { get; set; }

        public Guid CtsSalesInvoiceId { get; set; }

        public DateTime CtsCreatedDate { get; set; }

        public string? CtsCreatedBy { get; set; }

        public DateTime CtsLastModifiedDate { get; set; }

        public string? CtsLastModifiedBy { get; set; }

        public virtual CreditTransfer CtsCreditTransfer { get; set; } = null!;

        public virtual SalesInvoice CtsSalesInvoice { get; set; } = null!;
    }
}