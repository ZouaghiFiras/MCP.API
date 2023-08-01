namespace CED.Data.Entities
{
    public class WorkingOrderNote
    {
        public Guid WonId { get; set; }

        public byte[] WonTimeStamp { get; set; } = null!;

        public Guid WonWorkingOrderId { get; set; }

        public int WonLineNumber { get; set; }

        public Guid? WonRoleCodeId { get; set; }

        public Guid? WonNoteTypeId { get; set; }

        public string? WonFreeText { get; set; }

        public string? WonTitle { get; set; }

        public DateTime WonCreatedDate { get; set; }

        public string? WonCreatedBy { get; set; }

        public DateTime WonLastModifiedDate { get; set; }

        public string? WonLastModifiedBy { get; set; }

        public virtual NoteType? WonNoteType { get; set; }

        public virtual RoleCode? WonRoleCode { get; set; }

        public virtual WorkingOrder WonWorkingOrder { get; set; } = null!;

        public virtual ICollection<WorkingOrderNoteRole> WorkingOrderNoteRoles { get; } =
            new List<WorkingOrderNoteRole>();
    }
}