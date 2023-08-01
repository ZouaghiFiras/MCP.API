namespace CED.Data.Entities
{
    public class WorkingOrderLineCostNote
    {
        public Guid WolcnId { get; set; }

        public byte[] WolcnTimeStamp { get; set; } = null!;

        public Guid WolcnWorkingOrderLineCostId { get; set; }

        public DateTime WolcnCreatedDate { get; set; }

        public string? WolcnCreatedBy { get; set; }

        public DateTime WolcnLastModifiedDate { get; set; }

        public string? WolcnLastModifiedBy { get; set; }

        public int WolcnLineNumber { get; set; }

        public Guid? WolcnRoleCodeId { get; set; }

        public Guid? WolcnNoteTypeId { get; set; }

        public string? WolcnFreeText { get; set; }

        public virtual NoteType? WolcnNoteType { get; set; }

        public virtual RoleCode? WolcnRoleCode { get; set; }

        public virtual WorkingOrderLineCost WolcnWorkingOrderLineCost { get; set; } = null!;
    }
}