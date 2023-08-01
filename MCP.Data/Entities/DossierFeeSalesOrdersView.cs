namespace CED.Data.Entities
{
    public class DossierFeeSalesOrdersView
    {
        public Guid DossierId { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid ClientId { get; set; }

        public Guid? ProductId { get; set; }

        public decimal? SalesOdersAmount { get; set; }

        public Guid? DossierWorkActivityId { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}