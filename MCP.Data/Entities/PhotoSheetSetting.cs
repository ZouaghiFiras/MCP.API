namespace CED.Data.Entities
{
    public class PhotoSheetSetting
    {
        public Guid PssId { get; set; }

        public byte[] PssTimeStamp { get; set; } = null!;

        public Guid PssDossierId { get; set; }

        public string PssDocumentId { get; set; } = null!;

        public short? PssSequence { get; set; }

        public DateTime PssCreatedDate { get; set; }

        public string? PssCreatedBy { get; set; }

        public DateTime PssLastModifiedDate { get; set; }

        public string? PssLastModifiedBy { get; set; }

        public virtual Dossier PssDossier { get; set; } = null!;
    }
}