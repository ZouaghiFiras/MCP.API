namespace CED.Data.Entities
{
    public class CreditTransferPurchaseInvoice
    {
        public Guid CtpId { get; set; }

        public byte[] CtpTimeStamp { get; set; } = null!;

        public Guid CtpCreditTransferId { get; set; }

        public Guid CtpPurchaseInvoiceId { get; set; }

        public DateTime CtpCreatedDate { get; set; }

        public string? CtpCreatedBy { get; set; }

        public DateTime CtpLastModifiedDate { get; set; }

        public string? CtpLastModifiedBy { get; set; }

        public virtual CreditTransfer CtpCreditTransfer { get; set; } = null!;

        public virtual PurchaseInvoice CtpPurchaseInvoice { get; set; } = null!;
    }
}