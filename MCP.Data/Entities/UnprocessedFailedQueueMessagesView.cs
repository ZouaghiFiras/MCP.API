namespace CED.Data.Entities
{
    public class UnprocessedFailedQueueMessagesView
    {
        public Guid Id { get; set; }

        public string Message { get; set; } = null!;

        public bool Processed { get; set; }

        public byte ProcessType { get; set; }

        public string? QueueSettingName { get; set; }

        public string? TopicSettingName { get; set; }

        public string? FailedReason { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}