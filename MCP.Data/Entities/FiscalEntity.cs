namespace CED.Data.Entities
{
    public class FiscalEntity
    {
        public Guid FeId { get; set; }

        public byte[] FeTimeStamp { get; set; } = null!;

        public DateTime FeCreatedDate { get; set; }

        public string? FeCreatedBy { get; set; }

        public DateTime FeLastModifiedDate { get; set; }

        public string? FeLastModifiedBy { get; set; }

        public virtual OrganizationUnit Fe { get; set; } = null!;

        public virtual ICollection<LegalEntity> LegalEntities { get; } = new List<LegalEntity>();
    }
}