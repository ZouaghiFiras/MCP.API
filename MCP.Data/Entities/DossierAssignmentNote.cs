namespace CED.Data.Entities
{
    public class DossierAssignmentNote
    {
        public Guid DanId { get; set; }

        public byte[] DanTimeStamp { get; set; } = null!;

        public Guid DanDossierAssignmentId { get; set; }

        public int DanLineNumber { get; set; }

        public Guid? DanRoleCodeId { get; set; }

        public Guid? DanNoteTypeId { get; set; }

        public string? DanFreeText { get; set; }

        public string? DanTitle { get; set; }

        public DateTime DanCreatedDate { get; set; }

        public string? DanCreatedBy { get; set; }

        public DateTime DanLastModifiedDate { get; set; }

        public string? DanLastModifiedBy { get; set; }

        public virtual DossierAssignment DanDossierAssignment { get; set; } = null!;

        public virtual NoteType? DanNoteType { get; set; }

        public virtual RoleCode? DanRoleCode { get; set; }

        public virtual ICollection<DossierAssignmentNoteRole> DossierAssignmentNoteRoles { get; } =
            new List<DossierAssignmentNoteRole>();
    }
}