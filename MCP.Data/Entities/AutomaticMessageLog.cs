namespace CED.Data.Entities
{
    public class AutomaticMessageLog
    {
        public Guid AmlId { get; set; }

        public byte[] AmlTimeStamp { get; set; } = null!;

        public Guid? AmlDossierId { get; set; }

        public string AmlExternalId { get; set; } = null!;

        public string AmlLogMessage { get; set; } = null!;

        public DateTime AmlCreatedDate { get; set; }

        public string? AmlCreatedBy { get; set; }

        public DateTime AmlLastModifiedDate { get; set; }

        public string? AmlLastModifiedBy { get; set; }

        public Guid? AmlNewsfeedId { get; set; }

        public virtual Dossier? AmlDossier { get; set; }
    }
}