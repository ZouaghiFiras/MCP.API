namespace CED.Data.Entities
{
    public class PurchaseInvoicePendingSalesOrderView
    {
        public Guid Id { get; set; }

        public decimal? NetAmount { get; set; }

        public bool IsCredit { get; set; }

        public Guid? DossierId { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}