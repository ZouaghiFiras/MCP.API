namespace CED.Data.Entities
{
    public class TaskMember
    {
        public Guid TasmId { get; set; }

        public byte[] TasmTimeStamp { get; set; } = null!;

        public Guid TasmTaskId { get; set; }

        public Guid TasmEmployeeId { get; set; }

        public DateTime TasmCreatedDate { get; set; }

        public string? TasmCreatedBy { get; set; }

        public DateTime TasmLastModifiedDate { get; set; }

        public string? TasmLastModifiedBy { get; set; }

        public virtual Employee TasmEmployee { get; set; } = null!;

        public virtual Task TasmTask { get; set; } = null!;
    }
}