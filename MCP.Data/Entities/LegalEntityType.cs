namespace CED.Data.Entities
{
    public class LegalEntityType
    {
        public Guid LetId { get; set; }

        public byte[] LetTimeStamp { get; set; } = null!;

        public string LetCode { get; set; } = null!;

        public string? LetShortName { get; set; }

        public string LetLongName { get; set; } = null!;

        public bool LetInactive { get; set; }

        public DateTime LetCreatedDate { get; set; }

        public string? LetCreatedBy { get; set; }

        public DateTime LetLastModifiedDate { get; set; }

        public string? LetLastModifiedBy { get; set; }

        public virtual ICollection<LegalEntity> LegalEntities { get; } = new List<LegalEntity>();
    }
}