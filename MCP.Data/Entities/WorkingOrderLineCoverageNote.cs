namespace CED.Data.Entities
{
    public class WorkingOrderLineCoverageNote
    {
        public Guid WoccnId { get; set; }

        public byte[] WoccnTimeStamp { get; set; } = null!;

        public Guid WoccnWorkingOrderLineCoverageId { get; set; }

        public DateTime WoccnCreatedDate { get; set; }

        public string? WoccnCreatedBy { get; set; }

        public DateTime WoccnLastModifiedDate { get; set; }

        public string? WoccnLastModifiedBy { get; set; }

        public int WoccnLineNumber { get; set; }

        public Guid? WoccnRoleCodeId { get; set; }

        public Guid? WoccnNoteTypeId { get; set; }

        public string? WoccnFreeText { get; set; }

        public virtual NoteType? WoccnNoteType { get; set; }

        public virtual RoleCode? WoccnRoleCode { get; set; }

        public virtual WorkingOrderLineCoverage WoccnWorkingOrderLineCoverage { get; set; } = null!;
    }
}