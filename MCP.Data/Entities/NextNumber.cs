namespace CED.Data.Entities
{
    public class NextNumber
    {
        public Guid NexId { get; set; }

        public byte[] NexTimeStamp { get; set; } = null!;

        public string NexName { get; set; } = null!;

        public string? NexDescription { get; set; }

        public long NexNumber { get; set; }

        public long NexStartRange { get; set; }

        public long? NexEndRange { get; set; }

        public DateTime NexStartDate { get; set; }

        public DateTime? NexEndDate { get; set; }

        public DateTime NexCreatedDate { get; set; }

        public string? NexCreatedBy { get; set; }

        public DateTime NexLastModifiedDate { get; set; }

        public string? NexLastModifiedBy { get; set; }
    }
}