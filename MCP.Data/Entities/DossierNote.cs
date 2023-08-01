namespace CED.Data.Entities
{
    public class DossierNote
    {
        public Guid DonId { get; set; }

        public byte[] DonTimeStamp { get; set; } = null!;

        public Guid DonDossierId { get; set; }

        public int DonLineNumber { get; set; }

        public Guid? DonRoleCodeId { get; set; }

        public Guid? DonNoteTypeId { get; set; }

        public string? DonFreeText { get; set; }

        public DateTime DonCreatedDate { get; set; }

        public string? DonCreatedBy { get; set; }

        public DateTime DonLastModifiedDate { get; set; }

        public string? DonLastModifiedBy { get; set; }

        public bool DonInactive { get; set; }

        public virtual Dossier DonDossier { get; set; } = null!;

        public virtual NoteType? DonNoteType { get; set; }

        public virtual RoleCode? DonRoleCode { get; set; }
    }
}