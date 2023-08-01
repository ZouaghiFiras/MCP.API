namespace CED.Data.Entities
{
    public class DossierPendingFeeSalesOrdersView
    {
        public Guid Id { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? LegalEntityId { get; set; }

        public Guid ClientId { get; set; }

        public Guid ProductId { get; set; }

        public string? DossierStatusType { get; set; }

        public DateTime? DossierStatusDate { get; set; }

        public string? EntrySystem { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}