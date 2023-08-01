namespace CED.Data.Entities
{
    public class DossierAttachment
    {
        public Guid DatId { get; set; }

        public byte[] DatTimeStamp { get; set; } = null!;

        public Guid DatDossierId { get; set; }

        public Guid DatDocumentId { get; set; }

        public DateTime DatCreatedDate { get; set; }

        public string? DatCreatedBy { get; set; }

        public DateTime DatLastModifiedDate { get; set; }

        public string? DatLastModifiedBy { get; set; }

        public bool DatInactive { get; set; }

        public virtual Document DatDocument { get; set; } = null!;

        public virtual Dossier DatDossier { get; set; } = null!;
    }
}