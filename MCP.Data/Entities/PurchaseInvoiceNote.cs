namespace CED.Data.Entities
{
    public class PurchaseInvoiceNote
    {
        public Guid PinId { get; set; }

        public byte[] PinTimeStamp { get; set; } = null!;

        public Guid PinPurchaseInvoiceId { get; set; }

        public string PinNotes { get; set; } = null!;

        public DateTime PinCreatedDate { get; set; }

        public string? PinCreatedBy { get; set; }

        public DateTime PinLastModifiedDate { get; set; }

        public string? PinLastModifiedBy { get; set; }

        public virtual PurchaseInvoice PinPurchaseInvoice { get; set; } = null!;
    }
}