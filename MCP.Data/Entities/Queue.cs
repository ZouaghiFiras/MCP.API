namespace CED.Data.Entities
{
    public class Queue
    {
        public Guid QueId { get; set; }

        public byte[] QueTimeStamp { get; set; } = null!;

        public byte QueProcessType { get; set; }

        public string QueMessage { get; set; } = null!;

        public bool QueProcessed { get; set; }

        public DateTime QueCreatedDate { get; set; }

        public string? QueCreatedBy { get; set; }

        public DateTime QueLastModifiedDate { get; set; }

        public string? QueLastModifiedBy { get; set; }
    }
}