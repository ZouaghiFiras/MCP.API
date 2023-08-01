namespace CED.Data.Entities
{
    public class PurchaseInvoiceLinesOpenView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? ServiceId { get; set; }

        public Guid? MainServiceGroupId { get; set; }

        public Guid? SubServiceGroupId { get; set; }

        public decimal? OpenNetAmount { get; set; }

        public string? EntrySystem { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}