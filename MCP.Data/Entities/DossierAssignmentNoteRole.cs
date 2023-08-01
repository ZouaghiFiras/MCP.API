namespace CED.Data.Entities
{
    public class DossierAssignmentNoteRole
    {
        public Guid DanrId { get; set; }

        public byte[] DanrTimeStamp { get; set; } = null!;

        public Guid DanrDossierAssignmentNoteId { get; set; }

        public string DanrAuthorizationGroupRoleId { get; set; } = null!;

        public DateTime DanrCreatedDate { get; set; }

        public string? DanrCreatedBy { get; set; }

        public DateTime DanrLastModifiedDate { get; set; }

        public string? DanrLastModifiedBy { get; set; }

        public virtual AuthorizationGroupRole DanrAuthorizationGroupRole { get; set; } = null!;

        public virtual DossierAssignmentNote DanrDossierAssignmentNote { get; set; } = null!;
    }
}