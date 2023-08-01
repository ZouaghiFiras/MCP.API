namespace CED.Data.Entities
{
    public class WorkingOrderLineNote
    {
        public Guid WolnId { get; set; }

        public byte[] WolnTimeStamp { get; set; } = null!;

        public Guid WolnWorkingOrderLineId { get; set; }

        public DateTime WolnCreatedDate { get; set; }

        public string? WolnCreatedBy { get; set; }

        public DateTime WolnLastModifiedDate { get; set; }

        public string? WolnLastModifiedBy { get; set; }

        public int WolnLineNumber { get; set; }

        public Guid? WolnRoleCodeId { get; set; }

        public Guid? WolnNoteTypeId { get; set; }

        public string? WolnFreeText { get; set; }

        public virtual NoteType? WolnNoteType { get; set; }

        public virtual RoleCode? WolnRoleCode { get; set; }

        public virtual WorkingOrderLine WolnWorkingOrderLine { get; set; } = null!;
    }
}