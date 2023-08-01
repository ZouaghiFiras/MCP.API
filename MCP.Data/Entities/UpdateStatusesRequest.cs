namespace CED.Data.Entities
{
    public class UpdateStatusesRequest
    {
        public Guid UsrId { get; set; }

        public byte[] UsrTimeStamp { get; set; } = null!;

        public DateTime UsrDate { get; set; }

        public bool UsrIsExecuted { get; set; }

        public DateTime UsrCreatedDate { get; set; }

        public string? UsrCreatedBy { get; set; }

        public DateTime UsrLastModifiedDate { get; set; }

        public string? UsrLastModifiedBy { get; set; }
    }
}