namespace CED.Data.Entities
{
    public class DraftForm
    {
        public Guid DrfId { get; set; }

        public byte[] DrfTimeStamp { get; set; } = null!;

        public string DrfUserName { get; set; } = null!;

        public string DrfDraftName { get; set; } = null!;

        public string? DrfDraftNumber { get; set; }

        public string? DrfJson { get; set; }

        public DateTime DrfCreatedDate { get; set; }

        public string? DrfCreatedBy { get; set; }

        public DateTime DrfLastModifiedDate { get; set; }

        public string? DrfLastModifiedBy { get; set; }
    }
}