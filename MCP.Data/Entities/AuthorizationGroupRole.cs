namespace CED.Data.Entities
{
    public class AuthorizationGroupRole
    {
        public string AgrId { get; set; } = null!;

        public byte[] AgrTimeStamp { get; set; } = null!;

        public DateTime AgrCreatedDate { get; set; }

        public string? AgrCreatedBy { get; set; }

        public DateTime AgrLastModifiedDate { get; set; }

        public string? AgrLastModifiedBy { get; set; }

        public virtual AuthorizationRole Agr { get; set; } = null!;

        public virtual ICollection<AuthorizationRoleInheritance> AuthorizationRoleInheritances { get; } =
            new List<AuthorizationRoleInheritance>();

        public virtual ICollection<DossierAssignmentNoteRole> DossierAssignmentNoteRoles { get; } =
            new List<DossierAssignmentNoteRole>();

        public virtual ICollection<Task> Tasks { get; } = new List<Task>();

        public virtual ICollection<WorkingOrderNoteRole> WorkingOrderNoteRoles { get; } =
            new List<WorkingOrderNoteRole>();
    }
}