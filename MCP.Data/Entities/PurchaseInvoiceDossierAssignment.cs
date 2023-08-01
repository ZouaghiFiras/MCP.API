namespace CED.Data.Entities
{
    public class PurchaseInvoiceDossierAssignment
    {
        public Guid PidaId { get; set; }

        public byte[] PidaTimeStamp { get; set; } = null!;

        public Guid PidaPurchaseInvoiceLineId { get; set; }

        public Guid PidaDossierAssignmentId { get; set; }

        public DateTime PidaCreatedDate { get; set; }

        public string? PidaCreatedBy { get; set; }

        public DateTime PidaLastModifiedDate { get; set; }

        public string? PidaLastModifiedBy { get; set; }

        public virtual DossierAssignment PidaDossierAssignment { get; set; } = null!;

        public virtual PurchaseInvoiceLine PidaPurchaseInvoiceLine { get; set; } = null!;
    }
}