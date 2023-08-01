namespace CED.Data.Entities
{
    public class FailedQueueMessage
    {
        public Guid FqmId { get; set; }

        public byte[] FqmTimeStamp { get; set; } = null!;

        public byte FqmProcessType { get; set; }

        public string FqmMessage { get; set; } = null!;

        public bool FqmProcessed { get; set; }

        public string? FqmQueueSettingName { get; set; }

        public string? FqmTopicSettingName { get; set; }

        public string? FqmFailedReason { get; set; }

        public DateTime FqmCreatedDate { get; set; }

        public string? FqmCreatedBy { get; set; }

        public DateTime FqmLastModifiedDate { get; set; }

        public string? FqmLastModifiedBy { get; set; }
    }
}