namespace CED.Data.Entities
{
    public class TaskNote
    {
        public Guid TasnId { get; set; }

        public byte[] TasnTimeStamp { get; set; } = null!;

        public Guid TasnTaskId { get; set; }

        public Guid TasnEmployeeId { get; set; }

        public string TasnNotes { get; set; } = null!;

        public DateTime TasnCreatedDate { get; set; }

        public string? TasnCreatedBy { get; set; }

        public DateTime TasnLastModifiedDate { get; set; }

        public string? TasnLastModifiedBy { get; set; }

        public virtual Employee TasnEmployee { get; set; } = null!;

        public virtual Task TasnTask { get; set; } = null!;
    }
}