namespace CED.Data.Entities
{
    public class ExactGlobeLegalEntity
    {
        public Guid EgId { get; set; }

        public Guid EgLegalEntityId { get; set; }

        public DateTime EgEffectiveDate { get; set; }

        public DateTime? EgTerminationDate { get; set; }

        public string EgDatabaseName { get; set; } = null!;

        public string EgDatabaseServer { get; set; } = null!;

        public string EgAdministrationName { get; set; } = null!;

        public int EgAdministrationNumber { get; set; }

        public DateTime EgCreatedDate { get; set; }

        public string? EgCreatedBy { get; set; }

        public DateTime EgLastModifiedDate { get; set; }

        public string? EgLastModifiedBy { get; set; }

        public virtual LegalEntity EgLegalEntity { get; set; } = null!;
    }
}