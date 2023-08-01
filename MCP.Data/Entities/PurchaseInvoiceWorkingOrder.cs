namespace CED.Data.Entities
{
    public class PurchaseInvoiceWorkingOrder
    {
        public Guid PiwoId { get; set; }

        public byte[] PiwoTimeStamp { get; set; } = null!;

        public Guid PiwoPurchaseInvoiceLineId { get; set; }

        public Guid PiwoWorkingOrderLineCostId { get; set; }

        public decimal PiwoGrossAmount { get; set; }

        public decimal PiwoNetAmount { get; set; }

        public decimal PiwoTaxAmount { get; set; }

        public bool PiwoInactive { get; set; }

        public DateTime? PiwoInactiveDate { get; set; }

        public DateTime PiwoCreatedDate { get; set; }

        public string? PiwoCreatedBy { get; set; }

        public DateTime PiwoLastModifiedDate { get; set; }

        public string? PiwoLastModifiedBy { get; set; }

        public virtual PurchaseInvoiceLine PiwoPurchaseInvoiceLine { get; set; } = null!;

        public virtual WorkingOrderLineCost PiwoWorkingOrderLineCost { get; set; } = null!;
    }
}